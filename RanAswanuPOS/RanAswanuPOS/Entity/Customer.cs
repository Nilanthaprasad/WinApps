using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanAswanuPOS.Entity
{
    public class Customer
    {
        private long customerID;
        private String firstName;
        private String lastName;
        private String city;
        private String email;
        private String postCode;

        //with the starting underscore it specifies that they are taken from the _0kg_postmeta table
        private String _billing_email;
        private String _billing_postcode;
        private String _billing_city;
        private String _billing_address_2;
        private String _billing_address_1;
        private String _billing_first_name;
        private String _billing_last_name;
        private String _billing_phone;
        private String _shipping_first_name;
        private String _shipping_last_name;
        private String _shipping_address_1;
        private String _shipping_address_2;
        private String _shipping_city;
        private String _shipping_post;

        public long CustomerID { get => customerID; set => customerID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }
        public string PostCode { get => postCode; set => postCode = value; }

        public string Billing_email { get => _billing_email; set => _billing_email = value; }
        public string Billing_postcode { get => _billing_postcode; set => _billing_postcode = value; }
        public string Billing_city { get => _billing_city; set => _billing_city = value; }
        public string Billing_address_2 { get => _billing_address_2; set => _billing_address_2 = value; }
        public string Billing_address_1 { get => _billing_address_1; set => _billing_address_1 = value; }
        public string Billing_first_name { get => _billing_first_name; set => _billing_first_name = value; }
        public string Billing_last_name { get => _billing_last_name; set => _billing_last_name = value; }
        public string Billing_phone { get => _billing_phone; set => _billing_phone = value; }
        public string Shipping_first_name { get => _shipping_first_name; set => _shipping_first_name = value; }
        public string Shipping_last_name { get => _shipping_last_name; set => _shipping_last_name = value; }
        public string Shipping_address_1 { get => _shipping_address_1; set => _shipping_address_1 = value; }
        public string Shipping_address_2 { get => _shipping_address_2; set => _shipping_address_2 = value; }
        public string Shipping_city { get => _shipping_city; set => _shipping_city = value; }
        public string Shipping_post { get => _shipping_post; set => _shipping_post = value; }

        public Customer(long customerID, String firstName, String lastName, String email, String postCode, String city)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.email = email;
            this.postCode = postCode;
        }

        public Customer(long customerID, String firstName, String lastName, String city)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;           
        }



    }
}
