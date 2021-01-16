using AccessCapturer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessCapturer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Accessers accessers = new Accessers();
            
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=cms;User ID=cmsadmin;Password=Honeybc01");
            conn.Open();


            #region first

            

            SqlCommand firstcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'TKK1' ORDER BY [TRANSIT_DATE] DESC", conn);
            int firstsbi=0;
            SqlDataReader firstCardReader = firstcmd.ExecuteReader();
            while (firstCardReader.Read())
            {
                var data = firstCardReader.GetValue(0).ToString();
                firstsbi = int.Parse(data);
                accessers.firstCardNu = firstCardReader.GetValue(1).ToString();
                accessers.firstDirection = firstCardReader.GetValue(2).ToString();
            }
            firstCardReader.Close();
            SqlCommand firstGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            firstGetInfo.Parameters.AddWithValue("@SBI", firstsbi);
            SqlDataReader firstdr = firstGetInfo.ExecuteReader();
            while (firstdr.Read())
            {
                accessers.firtsName = firstdr.GetValue(1).ToString();
                accessers.firstSurname = firstdr.GetValue(2).ToString();

                //accessers.firstImage = firstdr.GetValue(3).ToString();
                accessers.firstImage = "http://ebi500dra/AccessCapturer/cmsimage/" + firstdr.GetValue(3).ToString();
            }
            firstdr.Close();
            firstcmd.Dispose();
            firstGetInfo.Dispose();

            #endregion


            #region second

            SqlCommand secondcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'TESTTKEY' ORDER BY [TRANSIT_DATE] DESC", conn);
            int secondsbi = 0;
            SqlDataReader secondCardReader = secondcmd.ExecuteReader();
            while (secondCardReader.Read())
            {
                var data = secondCardReader.GetValue(0).ToString();
                secondsbi = int.Parse(data);
                accessers.secondCardNu = secondCardReader.GetValue(1).ToString();
                accessers.secondDirection = secondCardReader.GetValue(2).ToString();
            }
            secondCardReader.Close();
            SqlCommand secondGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            secondGetInfo.Parameters.AddWithValue("@SBI", secondsbi);
            SqlDataReader seconddr = secondGetInfo.ExecuteReader();
            while (seconddr.Read())
            {
                accessers.secondName = seconddr.GetValue(1).ToString();
                accessers.secondSurname = seconddr.GetValue(2).ToString();
                //accessers.secondImage = seconddr.GetValue(3).ToString();
                accessers.secondImage = "http://ebi500dra/AccessCapturer/cmsimage/" + seconddr.GetValue(3).ToString();
            }
            seconddr.Close();
            secondcmd.Dispose();
            secondGetInfo.Dispose();

            #endregion


            #region third

            SqlCommand thirdcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'DOORVO' ORDER BY [TRANSIT_DATE] DESC", conn);
            int thirdsbi = 0;
            SqlDataReader thirdCardReader = thirdcmd.ExecuteReader();
            while (thirdCardReader.Read())
            {
                var data = thirdCardReader.GetValue(0).ToString();
                thirdsbi = int.Parse(data);
                accessers.thirdCardNu = thirdCardReader.GetValue(1).ToString();
                accessers.thirdDirection = thirdCardReader.GetValue(2).ToString();
            }
            thirdCardReader.Close();
            SqlCommand thirdGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            thirdGetInfo.Parameters.AddWithValue("@SBI", thirdsbi);
            SqlDataReader thirddr = thirdGetInfo.ExecuteReader();
            while (thirddr.Read())
            {
                accessers.thirdName = thirddr.GetValue(1).ToString();
                accessers.thirdSurname = thirddr.GetValue(2).ToString();
                //accessers.thirdImage = thirddr.GetValue(3).ToString();
                accessers.thirdImage = "http://ebi500dra/AccessCapturer/cmsimage/" + thirddr.GetValue(3).ToString();
            }
            thirddr.Close();
            thirdcmd.Dispose();
            thirdGetInfo.Dispose();

            #endregion

            #region forth

            SqlCommand forthcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'TKEYMEMO' ORDER BY [TRANSIT_DATE] DESC", conn);
            int forthsbi = 0;
            SqlDataReader forthCardReader = forthcmd.ExecuteReader();
            while (forthCardReader.Read())
            {
                var data = forthCardReader.GetValue(0).ToString();
                forthsbi = int.Parse(data);
                accessers.forthCardNu = forthCardReader.GetValue(1).ToString();
                accessers.forthDirection = forthCardReader.GetValue(2).ToString();
            }
            forthCardReader.Close();
            SqlCommand forthGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            forthGetInfo.Parameters.AddWithValue("@SBI", forthsbi);
            SqlDataReader forthdr = forthGetInfo.ExecuteReader();
            while (forthdr.Read())
            {
                accessers.forthName = forthdr.GetValue(1).ToString();
                accessers.forthSurname = forthdr.GetValue(2).ToString();
                //accessers.forthImage = forthdr.GetValue(3).ToString();
                accessers.forthImage = "http://ebi500dra/AccessCapturer/cmsimage/" + forthdr.GetValue(3).ToString();
            }
            forthdr.Close();
            forthcmd.Dispose();
            forthGetInfo.Dispose();

            #endregion

            conn.Close();
            //ViewBag.Message = accessers;
            return View(accessers);
        }

        public ActionResult Cotopark() 
        {
            Accessers accessers = new Accessers();

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=cms;User ID=cmsadmin;Password=Honeybc01");
            conn.Open();


            #region first



            SqlCommand firstcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'C_T6_K8' ORDER BY [TRANSIT_DATE] DESC", conn);
            int firstsbi = 0;
            SqlDataReader firstCardReader = firstcmd.ExecuteReader();
            while (firstCardReader.Read())
            {
                var data = firstCardReader.GetValue(0).ToString();
                firstsbi = int.Parse(data);
                accessers.firstCardNu = firstCardReader.GetValue(1).ToString();
                accessers.firstDirection= firstCardReader.GetValue(2).ToString() == "Entry" ? "Giriş" :"Çıkış";
            }
            firstCardReader.Close();
            SqlCommand firstGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            firstGetInfo.Parameters.AddWithValue("@SBI", firstsbi);
            SqlDataReader firstdr = firstGetInfo.ExecuteReader();
            while (firstdr.Read())
            {
                accessers.firtsName = firstdr.GetValue(1).ToString();
                accessers.firstSurname = firstdr.GetValue(2).ToString();

                //accessers.firstImage = firstdr.GetValue(3).ToString();
                accessers.firstImage = "file://10.34.60.2/HolderImages/" + firstdr.GetValue(3).ToString();
            }
            firstdr.Close();
            firstcmd.Dispose();
            firstGetInfo.Dispose();

            #endregion


            #region second

            SqlCommand secondcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'C_T6_K10' ORDER BY [TRANSIT_DATE] DESC", conn);
            int secondsbi = 0;
            SqlDataReader secondCardReader = secondcmd.ExecuteReader();
            while (secondCardReader.Read())
            {
                var data = secondCardReader.GetValue(0).ToString();
                secondsbi = int.Parse(data);
                accessers.secondCardNu = secondCardReader.GetValue(1).ToString();
                accessers.secondDirection = secondCardReader.GetValue(2).ToString() == "Entry" ? "Giriş" : "Çıkış";
            }
            secondCardReader.Close();
            SqlCommand secondGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            secondGetInfo.Parameters.AddWithValue("@SBI", secondsbi);
            SqlDataReader seconddr = secondGetInfo.ExecuteReader();
            while (seconddr.Read())
            {
                accessers.secondName = seconddr.GetValue(1).ToString();
                accessers.secondSurname = seconddr.GetValue(2).ToString();
                //accessers.secondImage = seconddr.GetValue(3).ToString();
                accessers.secondImage = "file://10.34.60.2/HolderImages/" + seconddr.GetValue(3).ToString();
            }
            seconddr.Close();
            secondcmd.Dispose();
            secondGetInfo.Dispose();

            #endregion


        

            conn.Close();
            //ViewBag.Message = accessers;
            return View(accessers);

        }

        public ActionResult ArastirmaciOtopark()
        {
            Accessers accessers = new Accessers();

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=cms;User ID=cmsadmin;Password=Honeybc01");
            conn.Open();


            #region first



            SqlCommand firstcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'B_T2_K4' ORDER BY [TRANSIT_DATE] DESC", conn);
            int firstsbi = 0;
            SqlDataReader firstCardReader = firstcmd.ExecuteReader();
            while (firstCardReader.Read())
            {
                var data = firstCardReader.GetValue(0).ToString();
                firstsbi = int.Parse(data);
                accessers.firstCardNu = firstCardReader.GetValue(1).ToString();
                accessers.firstDirection = firstCardReader.GetValue(2).ToString() == "Entry" ? "Giriş" : "Çıkış";
            }
            firstCardReader.Close();
            SqlCommand firstGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            firstGetInfo.Parameters.AddWithValue("@SBI", firstsbi);
            SqlDataReader firstdr = firstGetInfo.ExecuteReader();
            while (firstdr.Read())
            {
                accessers.firtsName = firstdr.GetValue(1).ToString();
                accessers.firstSurname = firstdr.GetValue(2).ToString();

                //accessers.firstImage = firstdr.GetValue(3).ToString();
                accessers.firstImage = "file://10.34.60.2/HolderImages/" + firstdr.GetValue(3).ToString();
            }
            firstdr.Close();
            firstcmd.Dispose();
            firstGetInfo.Dispose();

            #endregion


            #region second

            SqlCommand secondcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'B_T2_K5' ORDER BY [TRANSIT_DATE] DESC", conn);
            int secondsbi = 0;
            SqlDataReader secondCardReader = secondcmd.ExecuteReader();
            while (secondCardReader.Read())
            {
                var data = secondCardReader.GetValue(0).ToString();
                secondsbi = int.Parse(data);
                accessers.secondCardNu = secondCardReader.GetValue(1).ToString();
                accessers.secondDirection = secondCardReader.GetValue(2).ToString() == "Entry" ? "Giriş" : "Çıkış";
            }
            secondCardReader.Close();
            SqlCommand secondGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            secondGetInfo.Parameters.AddWithValue("@SBI", secondsbi);
            SqlDataReader seconddr = secondGetInfo.ExecuteReader();
            while (seconddr.Read())
            {
                accessers.secondName = seconddr.GetValue(1).ToString();
                accessers.secondSurname = seconddr.GetValue(2).ToString();
                //accessers.secondImage = seconddr.GetValue(3).ToString();
                accessers.secondImage = "file://10.34.60.2/HolderImages/" + seconddr.GetValue(3).ToString();
            }
            seconddr.Close();
            secondcmd.Dispose();
            secondGetInfo.Dispose();

            #endregion




            conn.Close();
            //ViewBag.Message = accessers;
            return View(accessers);

        }


        public ActionResult BGirisi()
        {
            Accessers accessers = new Accessers();

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=cms;User ID=cmsadmin;Password=Honeybc01");
            conn.Open();


            #region first



            SqlCommand firstcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'B_T3_K4' ORDER BY [TRANSIT_DATE] DESC", conn);
            int firstsbi = 0;
            SqlDataReader firstCardReader = firstcmd.ExecuteReader();
            while (firstCardReader.Read())
            {
                var data = firstCardReader.GetValue(0).ToString();
                firstsbi = int.Parse(data);
                accessers.firstCardNu = firstCardReader.GetValue(1).ToString();
                accessers.firstDirection = firstCardReader.GetValue(2).ToString() == "Entry" ? "Giriş" : "Çıkış";
            }
            firstCardReader.Close();
            SqlCommand firstGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            firstGetInfo.Parameters.AddWithValue("@SBI", firstsbi);
            SqlDataReader firstdr = firstGetInfo.ExecuteReader();
            while (firstdr.Read())
            {
                accessers.firtsName = firstdr.GetValue(1).ToString();
                accessers.firstSurname = firstdr.GetValue(2).ToString();

                //accessers.firstImage = firstdr.GetValue(3).ToString();
                accessers.firstImage = "file://10.34.60.2/HolderImages/" + firstdr.GetValue(3).ToString();
            }
            firstdr.Close();
            firstcmd.Dispose();
            firstGetInfo.Dispose();

            #endregion


            #region second

            SqlCommand secondcmd = new SqlCommand("SELECT TOP 1 SBI_ID, CARD_NUMBER, STR_DIRECTION FROM [cms].[dbo].[HA_TRANSIT] Where [TERMINAL]= 'B_T3_K5' ORDER BY [TRANSIT_DATE] DESC", conn);
            int secondsbi = 0;
            SqlDataReader secondCardReader = secondcmd.ExecuteReader();
            while (secondCardReader.Read())
            {
                var data = secondCardReader.GetValue(0).ToString();
                secondsbi = int.Parse(data);
                accessers.secondCardNu = secondCardReader.GetValue(1).ToString();
                accessers.secondDirection = secondCardReader.GetValue(2).ToString() == "Entry" ? "Giriş" : "Çıkış";
            }
            secondCardReader.Close();
            SqlCommand secondGetInfo = new SqlCommand("SELECT [SbiID],[Name],[Surname],[CHImage] FROM[cms].[dbo].[Employee] where SbiID =@SBI", conn);
            secondGetInfo.Parameters.AddWithValue("@SBI", secondsbi);
            SqlDataReader seconddr = secondGetInfo.ExecuteReader();
            while (seconddr.Read())
            {
                accessers.secondName = seconddr.GetValue(1).ToString();
                accessers.secondSurname = seconddr.GetValue(2).ToString();
                //accessers.secondImage = seconddr.GetValue(3).ToString();
                accessers.secondImage = "file://10.34.60.2/HolderImages/" + seconddr.GetValue(3).ToString();
            }
            seconddr.Close();
            secondcmd.Dispose();
            secondGetInfo.Dispose();

            #endregion




            conn.Close();
            //ViewBag.Message = accessers;
            return View(accessers);

        }
    }
}