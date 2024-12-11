using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RanAswanuPOS.Entity;
using RanAswanuPOS.DataConn;
using MySql.Data.MySqlClient;

namespace RanAswanuPOS.EntityDao
{
    class OrderItemDao
    {
        private MySqlConnection dbCon;


        public OrderItemDao()
        {
            dbCon = DatabaseConnection.getConnection();
        }

        public List<OrderItem> getOrderItems(int orderId)
        {
            try
            {
                String query1 = "SELECT  " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ITEM_ID + ", " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ITEM_NAME +
                                 " FROM " + DataDictionary.ORDER_ITEM_TABLE +
                                 " WHERE " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ID + " = @orderid" +
                                 " AND " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ITEM_TYPE + " <> 'shipping'";

                //Create a list to store the result
                List<OrderItem> orderItemList = new List<OrderItem>();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query1, dbCon);

                cmd.Parameters.AddWithValue("@orderid", orderId);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list

                String orderItemName;
                int orderItemId;
                int productId = 0;
                int quantity=0;
                double lineSubtotal=0;
                double lineTotal=0;
                OrderItem orderitem;
                Product prod;
                List<String> orderItemNames = new List<string>();
                List<int> orderItemIds = new List<int>();
                while (dataReader.Read())
                {
                    orderItemNames.Add(dataReader.GetString(1));
                    orderItemIds.Add(dataReader.GetInt32(0));

                }

                //close Data Reader
                dataReader.Close();

                //String query3 = "SELECT a.order_item_id, b.min_price  FROM _0kg_wc_order_product_lookup as a, _0kg_wc_product_meta_lookup as b " +
                //                "WHERE a.order_id = @orderid AND b.product_id = @

                //-----------------------
                int i = 0;

                while (i < orderItemNames.Count)
                {
                    String query2 = "SELECT a.meta_key, a.meta_value from _0KG_woocommerce_order_itemmeta as a WHERE (a.order_item_id = @orderitemid and a.meta_key = '_product_id') OR(a.order_item_id = @orderitemid and a.meta_key = '_qty') OR" +
                       "(a.order_item_id = @orderitemid and a.meta_key = '_line_subtotal') OR (a.order_item_id = @orderitemid and a.meta_key = '_line_total') ORDER BY a.order_item_id";

                    MySqlCommand cmd2 = new MySqlCommand(query2, dbCon);

                    cmd2.Parameters.AddWithValue("@orderitemid", orderItemIds[i]);

                    MySqlDataReader dataReader2 = cmd2.ExecuteReader();

                    //_line_subtotal
                    //_line_total
                    //_product_id
                    //_qty
                    while (dataReader2.Read())
                    {
                        switch (dataReader2.GetString(0))
                        {
                            case "_line_subtotal":
                                lineSubtotal = dataReader2.GetInt32(1);
                                break;
                            case "_line_total":
                                lineTotal = dataReader2.GetInt32(1);
                                break;
                            case "_product_id":
                                productId = dataReader2.GetInt32(1);
                                break;
                            case "_qty":
                                quantity = dataReader2.GetInt32(1);
                                break;
                        }
                        
                    }
                    prod = new Product(productId, orderItemNames[i]);
                    orderitem = new OrderItem(prod, quantity, lineSubtotal, lineTotal);
                    orderItemList.Add(orderitem);
                    dataReader2.Close();
                    //creating the product object
                    i++;

                }
                //---------------------------------------
                //return list to be displayed
                return orderItemList;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public List<OrderItem> getOrderItemsWithCustomer(int orderId, Customer customer)
        {
            try
            {
                String query1 = "SELECT  " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ITEM_ID + ", " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ITEM_NAME +
                                 " FROM " + DataDictionary.ORDER_ITEM_TABLE +
                                 " WHERE " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ID + " = @orderid" +
                                 " AND " + DataDictionary.ORDER_ITEM_TABLE_ORDER_ITEM_TYPE + " <> 'shipping'";

                //Create a list to store the result
                List<OrderItem> orderItemList = new List<OrderItem>();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query1, dbCon);

                cmd.Parameters.AddWithValue("@orderid", orderId);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list


                int productId = 0;
                int quantity = 0;
                double lineSubtotal = 0;
                double lineTotal = 0;
                OrderItem orderitem;
                Product prod;
                List<String> orderItemNames = new List<string>();
                List<int> orderItemIds = new List<int>();
                while (dataReader.Read())
                {
                    orderItemNames.Add(dataReader.GetString(1));
                    orderItemIds.Add(dataReader.GetInt32(0));

                }

                //close Data Reader
                dataReader.Close();


                int i = 0;

                while (i < orderItemNames.Count)
                {
                    String query2 = "SELECT a.meta_key, a.meta_value from _0KG_woocommerce_order_itemmeta as a WHERE (a.order_item_id = @orderitemid and a.meta_key = '_product_id') OR(a.order_item_id = @orderitemid and a.meta_key = '_qty') OR" +
                       "(a.order_item_id = @orderitemid and a.meta_key = '_line_subtotal') OR (a.order_item_id = @orderitemid and a.meta_key = '_line_total') ORDER BY a.order_item_id";

                    MySqlCommand cmd2 = new MySqlCommand(query2, dbCon);

                    cmd2.Parameters.AddWithValue("@orderitemid", orderItemIds[i]);

                    MySqlDataReader dataReader2 = cmd2.ExecuteReader();

                    //_line_subtotal
                    //_line_total
                    //_product_id
                    //_qty
                    while (dataReader2.Read())
                    {
                        switch (dataReader2.GetString(0))
                        {
                            case "_line_subtotal":
                                lineSubtotal = dataReader2.GetInt32(1);
                                break;
                            case "_line_total":
                                lineTotal = dataReader2.GetInt32(1);
                                break;
                            case "_product_id":
                                productId = dataReader2.GetInt32(1);
                                break;
                            case "_qty":
                                quantity = dataReader2.GetInt32(1);
                                break;
                        }

                    }
                    prod = new Product(productId, orderItemNames[i]);
                    orderitem = new OrderItem(prod, quantity, lineSubtotal, lineTotal);
                    orderItemList.Add(orderitem);
                    dataReader2.Close();
                    //creating the product object
                    i++;

                }

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

 
                MySqlCommand cmd3;
                MySqlDataReader dataReader3;



                cmd3 = new MySqlCommand(selectCustomerDataQuery, dbCon);
                cmd3.Parameters.AddWithValue("@orderid", orderId);
                dataReader3 = cmd3.ExecuteReader();


                    while (dataReader3.Read())
                    {
                        switch (dataReader3.GetString(0))
                        {
                            case "_billing_email":
                                customer.Billing_email = dataReader3.GetString(1);
                                break;
                            case " _billing_postcode":
                            customer.Billing_postcode = dataReader3.GetString(1);
                                break;
                            case "_billing_city":
                            customer.Billing_city = dataReader3.GetString(1);
                                break;
                            case "_billing_address_2":
                            customer.Billing_address_2 = dataReader3.GetString(1);
                                break;
                            case "_billing_address_1":
                            customer.Billing_address_1 = dataReader3.GetString(1);
                                break;
                            case "_billing_first_name":
                            customer.Billing_first_name = dataReader3.GetString(1);
                                break;
                            case "_billing_last_name":
                            customer.Billing_last_name = dataReader3.GetString(1);
                                break;
                            case "_billing_phone":
                            customer.Billing_phone = dataReader3.GetString(1);
                                break;
                            case "_shipping_first_name":
                            customer.Shipping_first_name = dataReader3.GetString(1);
                                break;
                            case "_shipping_last_name":
                            customer.Shipping_last_name = dataReader3.GetString(1);
                                break;
                            case "_shipping_address_1":
                            customer.Shipping_address_1 = dataReader3.GetString(1);
                                break;
                            case "_shipping_address_2":
                            customer.Shipping_address_2 = dataReader3.GetString(1);
                                break;
                            case "_shipping_city":
                            customer.Shipping_city = dataReader3.GetString(1);
                                break;
                            case "_shipping_post":
                            customer.Shipping_post = dataReader3.GetString(1);
                                break;
                        }

                    }
                dataReader3.Close();
                    //---------------------------------------
                    //return list to be displayed
                return orderItemList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
