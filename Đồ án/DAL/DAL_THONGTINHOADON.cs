﻿using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
namespace DAL
{
    public class DAL_THONGTINHOADON : DataPovier
    {
        public List<BEL_THONGTINHOADON> Lay_ThongTin(int id)
        {
            List<BEL_THONGTINHOADON> list = new List<BEL_THONGTINHOADON>();
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "select * from dbo.BillInfo where idBill =" + id;
            SqlCommand cmd = new SqlCommand(query, Getcon());
            DataTable data;
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foreach (DataRow item in dt.Rows)
                {
                    BEL_THONGTINHOADON thongTin = new BEL_THONGTINHOADON(item);
                    list.Add(thongTin);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return list;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {

            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "USP_InsertBillInfo " + idBill + " , " + idFood + ", " + count;
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                Getcon().Close();
            }

        }
    }
}
