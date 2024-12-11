using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanAswanuPOS.DataConn
{
    class DataDictionary
    {
        //USER TABLE
        public static String USER_TABLE = "_ran_posuser";
        public static String USER_TABLE_COL_USERNAME = "username";
        public static String USER_TABLE_COL_USERNAME_PARAM = "@username";
        public static String USER_TABLE_COL_PASSWORD = "password";
        public static String USER_TABLE_COL_PASSWORD_PARAM = "@password";

        public static String ORDER_TABLE = "_0KG_wc_order_stats";
        public static String ORDER_TABLE_COL_ORDER_ID = "order_id";
        public static String ORDER_TABLE_COL_DATE_CREATED = "date_created";
        public static String ORDER_TABLE_COL_NUM_ITEMS_SOLD = "num_items_sold";
        public static String ORDER_TABLE_COL_TOTAL_SALES = "total_sales";
        public static String ORDER_TABLE_COL_SHIPPING_TOTAL = "shipping_total";
        public static String ORDER_TABLE_COL_NET_TOTAL  = "net_total";
        public static String ORDER_TABLE_COL_CUSTOMER_ID = "customer_id";
        public static String ORDER_TABLE_COL_STATUS = "status";


        public static String CUSTOMER_TABLE = "_0KG_wc_customer_lookup";
        public static String CUSTOMER_TABLE_COL_CUSTOMER_ID = "customer_id";
        public static String CUSTOMER_TABLE_COL_FIRST_NAME = "first_name";
        public static String CUSTOMER_TABLE_COL_LAST_NAME = "last_name";
        public static String CUSTOMER_TABLE_COL_EMAIL = "email";
        public static String CUSTOMER_TABLE_COL_POST_CODE = "postcode";
        public static String CUSTOMER_TABLE_COL_CITY = "city";

        public static String ORDER_ITEM_TABLE = "_0KG_woocommerce_order_items";
        public static String ORDER_ITEM_TABLE_ORDER_ITEM_ID = "order_item_id";
        public static String ORDER_ITEM_TABLE_ORDER_ITEM_NAME = "order_item_name";
        public static String ORDER_ITEM_TABLE_ORDER_ITEM_TYPE = "order_item_type";
        public static String ORDER_ITEM_TABLE_ORDER_ID = "order_id";




        public static String getParameterOf(String column)
        {
            return "@" + column;
        }

       

    }
}
