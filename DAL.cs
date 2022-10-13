using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Final_Project
{
    class DAL
    {
        public static SqlConnection Getconnection()
        {
            string str = @"Data Source=DESKTOP-84J5DPF\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            try 
	        {	   
                con.Open();
		   // MessageBox.Show("Connect");
        	}
	        catch (Exception)
        	{
		MessageBox.Show("!!!");
		
	        }
            return con;

        }

        public static void AddsuplierData(Supplier sp)
        {
            SqlConnection con = DAL.Getconnection();
            string query = ("insert into Supplier_t values(@SupplierName,@Saddress,@Cell,@Company)");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SupplierName",sp.sname);
            cmd.Parameters.AddWithValue("@Saddress", sp.saddress);
            cmd.Parameters.AddWithValue("@Cell", sp.cellNo);
            cmd.Parameters.AddWithValue("@Company",sp.company);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Data Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
                
                throw;
            }
        }

        public static SqlDataReader Datafromdatabase(string query)
        {
            SqlConnection con = Getconnection();
          //  string query = "select SupplierID,SupplierName,Saddress,Cell,Company from Supplier_t where SupplierID='"+ Sp+ "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }

        public static void UpdateSupplierData(string query)
        {
            SqlConnection con = Getconnection();
           // string query = "Update Supplier_t set SupplierName='" + sp.sname + "',Saddress='" + sp.saddress + "',Cell='" + sp.cellNo + "',Company='" + sp.company + "'where SupplierID=" + sp.sid + " ;";
         // string query="update Supplier_t set Saddress='"+sp.saddress+"',Company='"+sp.company+"',SupplierName='"+sp.sname+"',Cell='"+sp.cellNo+"'where SupplierID="+sp.sid+";";
           //string query = "update Supplier_t set Saddress='12dadsa',Company='" + sp.company + "',SupplierName='" + sp.sname + "',Cell='" + sp.cellNo + "'where SupplierID=" + sp.sid + ";";
            
            SqlCommand cmd=new SqlCommand(query,con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }
        public static void UpdateInventory(string query)
        {
            SqlConnection con = Getconnection();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }

        public static void DeleteSupplierData(string q)
        {
            SqlConnection con = Getconnection();
         //   string query = "Delete From Supplier_t where  SupplierID='" + sp.sid + "';";
            SqlCommand cmd = new SqlCommand(q, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Not delete");
                throw;
            }
        }

        public static void SupplierDataGrid<t>(DataGridView view,t sp,string query, string table)
        {
            SqlConnection con = Getconnection();
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            string  tb= table;
          
            dt.Fill(ds,tb);
            view.DataSource = ds.Tables[tb];
        }

        public static void additemData(Item it)
        {
            SqlConnection con = DAL.Getconnection();
            //string query = ("insert into Supplier_t values(@SupplierName,@Saddress,@Cell,@Company)");

            string query = ("insert into Item_t values(@Barcode,@ItemName,@Descriptionn,@Price,@NoOfBoxes,@SupplierID)");

            //string query = ("insert into Item_t values(@Barcode,@ItemName,@Descriptionn,@Price,@NoOfBoxes,@Carton,@SupplierID)");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Barcode", it.Barcode);
            cmd.Parameters.AddWithValue("@ItemName", it.itemName);
            cmd.Parameters.AddWithValue("@Descriptionn", it.Description);
            cmd.Parameters.AddWithValue("@Price", it.price);

            cmd.Parameters.AddWithValue("@NoOfBoxes", it.noofbox);
            
            cmd.Parameters.AddWithValue("@SupplierID",it.Sid);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Data Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");

                throw;
            }
        }

        public static void addPurchaseItem(Purchase pch)
        {
            SqlConnection con = DAL.Getconnection();

            string query = ("insert into purchase_T values(@Barcode,@SupplierID,@NoofBOxes,@purchaseprice,@PurchaseDate,@ExpiryDate)");

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Barcode", pch.barcode);
            cmd.Parameters.AddWithValue("@SupplierID", pch.sid);
            cmd.Parameters.AddWithValue("@NoofBOxes",pch.noBox);

            cmd.Parameters.AddWithValue("@purchaseprice", pch.PurchasePrice);
            cmd.Parameters.AddWithValue("@PurchaseDate", pch.date);
            cmd.Parameters.AddWithValue("@ExpiryDate", pch.ExpiryDate);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Purchased Data Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");

                throw;
            }
        }

        public static void AddandUpdateInventory(Innventory inv)
        {
            SqlConnection con = DAL.Getconnection();

            string query = ("insert into Inventory values(@barcode,@itemName,@SalePrice,@PurchasePrice,@NoofBoxes,@ExpiryDate)");

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@barcode", inv.barcode);
            cmd.Parameters.AddWithValue("@itemName", inv.itemName);
            cmd.Parameters.AddWithValue("@SalePrice", inv.SalePrice);

            cmd.Parameters.AddWithValue("@PurchasePrice", inv.PurchasePrice);
            cmd.Parameters.AddWithValue("@NoofBoxes", inv.NoofBoxes);
            cmd.Parameters.AddWithValue("@ExpiryDate", inv.expiryDate);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("inventory Data Added");
            }
            catch (Exception)
            {
                //MessageBox.Show("Error invnener!!");

                throw;
            }

        }

        public static void addSale(Sale sal) 
        {
            SqlConnection con = DAL.Getconnection();

            string query = ("insert into Sale_t values(@customerName,@Barcode,@NoOfBoxes,@SaleDate,@Saleprice)");

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerName", sal.CustomerName);
            cmd.Parameters.AddWithValue("@Barcode", sal.Barcode);
            cmd.Parameters.AddWithValue("@NoofBOxes", sal.NoBoxes);

            cmd.Parameters.AddWithValue("@SaleDate", sal.SDate);
            cmd.Parameters.AddWithValue("@Saleprice", sal.SalePrice);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sale Data Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");

                throw;
            }
        }
        
    }
}
