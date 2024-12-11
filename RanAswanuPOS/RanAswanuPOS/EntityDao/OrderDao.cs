using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RanAswanuPOS.DataConn;
using RanAswanuPOS.Entity;


namespace RanAswanuPOS.EntityDao
{
    class OrderDao
    {
        private MySqlConnection dbCon;


        public OrderDao()
        {
            dbCon = DatabaseConnection.getConnection();
        }

        //public List<Order> getAllOrders()
        //{

        //    String[] columnList = { DataDictionary.ORDER_TABLE_COL_ORDER_ID,
        //                            DataDictionary.ORDER_TABLE_COL_DATE_CREATED,
        //                            DataDictionary.ORDER_TABLE_COL_CUSTOMER_ID,
        //                            DataDictionary.ORDER_TABLE_COL_NUM_ITEMS_SOLD,
        //                            DataDictionary.ORDER_TABLE_COL_NET_TOTAL,
        //                            DataDictionary.ORDER_TABLE_COL_SHIPPING_TOTAL,
        //                            DataDictionary.ORDER_TABLE_COL_TOTAL_SALES,
        //                            DataDictionary.ORDER_TABLE_COL_STATUS};

        //    String query = DatabaseUtil.getSelectStatementWithColumns(DataDictionary.ORDER_TABLE, columnList);

        //    //Create a list to store the result
        //    List<Order> orderList = new List<Order>();

        //    //Create Command
        //    MySqlCommand cmd = new MySqlCommand(query, dbCon);

        //    //Create a data reader and Execute the command
        //    MySqlDataReader dataReader = cmd.ExecuteReader();

        //    //Read the data and store them in the list

        //    while (dataReader.Read())
        //    {
        //        orderList.Add(new Order(dataReader.GetInt32(0), dataReader.GetDateTime(1), dataReader.GetInt32(2), "Customer",
        //                        dataReader.GetInt32(3), dataReader.GetDouble(4), dataReader.GetDouble(5),
        //                        dataReader.GetDouble(6), dataReader.GetString(7)));
        //    }

        //    //close Data Reader
        //    dataReader.Close();

        //    //close Connection
        //    //dbCon.Close();

        //    //return list to be displayed
        //    return orderList;
        //}

        public List<Order> getAllOrdersWithDateRangeAndCustomerNames(DateTime startDate, DateTime endDate)
        {
            String startDateparamvalue = "'" + startDate.Year + "-" + startDate.Month + "-" + startDate.Day + "'";
            String endDateParamValue = "'" + endDate.Year + "-" + endDate.Month + "-" + endDate.Day + "'";

            String query = "Select " + DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_ORDER_ID + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_DATE_CREATED + ", " +
                            DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_CUSTOMER_ID + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_NUM_ITEMS_SOLD + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_NET_TOTAL + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_SHIPPING_TOTAL + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_TOTAL_SALES + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_STATUS + ", " +

                             //Adding the data from customer column
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_FIRST_NAME + "," +
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_LAST_NAME + "," +
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_EMAIL + "," +
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_POST_CODE + "," +
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_CITY +

                             " FROM " + DataDictionary.ORDER_TABLE + ", " + DataDictionary.CUSTOMER_TABLE +
                             " WHERE " + DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_CUSTOMER_ID + " = " +
                                    DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_CUSTOMER_ID +
                               " AND " + DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_DATE_CREATED +
                               " BETWEEN " + "CAST( " + startDateparamvalue + " AS DATE) AND " + "CAST( " + endDateParamValue + " AS DATE)";
            //" BETWEEN " + "CAST( @startdate AS DATE) AND " + "CAST( @enddate AS DATE)";



            //Create a list to store the result
            List<Order> orderList = new List<Order>();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, dbCon);

            //cmd.Parameters.AddWithValue("@startdate", startDateparamvalue);
            //cmd.Parameters.AddWithValue("@enddate", endDateParamValue);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            //Read the data and store them in the list
            Customer customer;

            while (dataReader.Read())
            {
                customer = new Customer(dataReader.GetInt32(2),
                                                    dataReader.GetString(8),
                                                    dataReader.GetString(9),
                                                    dataReader.GetString(10),
                                                    dataReader.GetString(11),
                                                    dataReader.GetString(12));



                orderList.Add(new Order(dataReader.GetInt32(0),
                                        dataReader.GetDateTime(1),
                                        dataReader.GetInt32(2),
                                        dataReader.GetInt32(3),
                                        dataReader.GetDouble(4),
                                        dataReader.GetDouble(5),
                                        dataReader.GetDouble(6),
                                        dataReader.GetString(7),
                                        customer));
            }


            //close Data Reader
            dataReader.Close();

            //Getting the customer data

            String selectCustomerDataQuery = "SELECT meta_key, meta_value FROM _0KG_postmeta" +
                                       " WHERE post_id = @orderid " +
                                       "AND meta_key IN(" +
                                        "'_billing_email'," +
                                        "'_billing_postcode'," +
                                       "'_billing_city'," +
                                       "'_billing_address_2'," +
                                        "'_billing_address_1'," +
                                       " '_billing_first_name'," +
                                       "'_billing_last_name'," +
                                       " '_billing_phone'," +
                                       " '_shipping_first_name'," +
                                       "'_shipping_last_name'," +
                                       " '_shipping_address_1'," +
                                       " '_shipping_address_2'," +
                                       " '_shipping_city'," +
                                       " '_shipping_post')";

            int i = 0;
            MySqlCommand cmd2;
            MySqlDataReader dataReader2;

            Order order;
            while (orderList.Count > i)
            {
                order = orderList[i];
                cmd2 = new MySqlCommand(selectCustomerDataQuery, dbCon);
                cmd2.Parameters.AddWithValue("@orderid", order.OrderId);
                dataReader2 = cmd2.ExecuteReader();


                while (dataReader2.Read())
                {
                    switch (dataReader2.GetString(0))
                    {
                        case "_billing_email":
                            order.Customer.Billing_email = dataReader2.GetString(1);
                            break;
                        case " _billing_postcode":
                            order.Customer.Billing_postcode = dataReader2.GetString(1);
                            break;
                        case "_billing_city":
                            order.Customer.Billing_city = dataReader2.GetString(1);
                            break;
                        case "_billing_address_2":
                            order.Customer.Billing_address_2 = dataReader2.GetString(1);
                            break;
                        case "_billing_address_1":
                            order.Customer.Billing_address_1 = dataReader2.GetString(1);
                            break;
                        case "_billing_first_name":
                            order.Customer.Billing_first_name = dataReader2.GetString(1);
                            break;
                        case "_billing_last_name":
                            order.Customer.Billing_last_name = dataReader2.GetString(1);
                            break;
                        case "_billing_phone":
                            order.Customer.Billing_phone = dataReader2.GetString(1);
                            break;
                        case "_shipping_first_name":
                            order.Customer.Shipping_first_name = dataReader2.GetString(1);
                            break;
                        case "_shipping_last_name":
                            order.Customer.Shipping_last_name = dataReader2.GetString(1);
                            break;
                        case "_shipping_address_1":
                            order.Customer.Shipping_address_1 = dataReader2.GetString(1);
                            break;
                        case "_shipping_address_2":
                            order.Customer.Shipping_address_2 = dataReader2.GetString(1);
                            break;
                        case "_shipping_city":
                            order.Customer.Shipping_city = dataReader2.GetString(1);
                            break;
                        case "_shipping_post":
                            order.Customer.Shipping_post = dataReader2.GetString(1);
                            break;
                    }

                }
                dataReader2.Close();
                i++;
                //close Connection
                //dbCon.Close();

                //return list to be displayed
               
            }
            return orderList;
        }

        public List<Order> getAllOrdersLessDetailed(DateTime startDate, DateTime endDate)
        {
            String startDateparamvalue = "'" + startDate.Year + "-" + startDate.Month + "-" + startDate.Day + "'";
            String endDateParamValue = "'" + endDate.Year + "-" + endDate.Month + "-" + endDate.Day + "'";

            String query = "Select " + DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_ORDER_ID + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_DATE_CREATED + ", " +
                            DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_CUSTOMER_ID + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_NUM_ITEMS_SOLD + ", " +                            
                                                   DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_TOTAL_SALES + ", " +
                            DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_STATUS + ", " +

                             //Adding the data from customer column
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_FIRST_NAME + "," +
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_LAST_NAME + "," +
                             DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_CITY +

                             " FROM " + DataDictionary.ORDER_TABLE + ", " + DataDictionary.CUSTOMER_TABLE +
                             " WHERE " + DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_CUSTOMER_ID + " = " +
                                    DataDictionary.CUSTOMER_TABLE + "." + DataDictionary.CUSTOMER_TABLE_COL_CUSTOMER_ID +
                               " AND " + DataDictionary.ORDER_TABLE + "." + DataDictionary.ORDER_TABLE_COL_DATE_CREATED +
                               " BETWEEN " + "CAST( " + startDateparamvalue + " AS DATE) AND " + "CAST( " + endDateParamValue + " AS DATE)";




            //Create a list to store the result
            List<Order> orderList = new List<Order>();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, dbCon);

            //cmd.Parameters.AddWithValue("@startdate", startDateparamvalue);
            //cmd.Parameters.AddWithValue("@enddate", endDateParamValue);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            //Read the data and store them in the list
            Customer customer;

            while (dataReader.Read())
            {
                customer = new Customer(dataReader.GetInt32(2),
                                        dataReader.GetString(6),
                                        dataReader.GetString(7),
                                        dataReader.GetString(8));

                orderList.Add(new Order(dataReader.GetInt32(0),
                                        dataReader.GetDateTime(1),
                                        dataReader.GetInt32(2),
                                        dataReader.GetInt32(3),
                                        dataReader.GetDouble(4),
                                        dataReader.GetString(5),                                      
                                        customer));
            }
            
            //close Data Reader
            dataReader.Close();           
            return orderList;
        }
    }
}
