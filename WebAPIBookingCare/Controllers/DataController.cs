using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIBookingCare.Controllers
{
    public class DataController : ApiController
    {
        [Route("api/DataController/GetChuyenKhoa")]
        [HttpGet]
        public IHttpActionResult GetChuyenKhoa()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("proc_getKhoa");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/GetBacSi")]
        [HttpGet]
        public IHttpActionResult GetBacSi()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("proc_getBacSi");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/GetBacSiTheoKhoa")]
        [HttpGet]
        public IHttpActionResult GetBacSiTheoKhao(string chuyen_khoa)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("chuyen_khoa", chuyen_khoa);
                DataTable result = Database.Database.ReadTable("proc_getBacSiTheoKhoa", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        [Route("api/DataController/GetLichKham")]
        [HttpGet]
        public IHttpActionResult GetLichKham()
        {
            try
            {
                DataTable result = Database.Database.ReadTable("proc_getLichKham");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/GetLichKhamTheoNgayKhoa")]
        [HttpGet]
        public IHttpActionResult GetLichKhamTheoNgayKhoa(string ngay,string chuyen_khoa)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("ngay",ngay);
                param.Add("chuyen_khoa", chuyen_khoa);
                DataTable result = Database.Database.ReadTable("proc_getLichKhamTheoNgayChuyenKhoa",param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        [Route("api/DataController/GetChiTietLichKham")]
        [HttpGet]
        public IHttpActionResult GetChiTietLichKham(string id_lich_kham)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("id_lich_kham", id_lich_kham);
                DataTable result = Database.Database.ReadTable("proc_getChiTietLichKham", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/GetPhieuKhamBenh")]
        [HttpGet]
        public IHttpActionResult GetPhieuKhamBenh(string email_user)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("email_user",email_user);
                DataTable result = Database.Database.ReadTable("proc_getPhieuKhamBenhTheoEmail", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/PhieuKhamBenhTheoEmail")]
        [HttpGet]
        public IHttpActionResult PhieuKhamBenhTheoEmail(string email_user)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("email_user", email_user);
                DataTable result = Database.Database.ReadTable("proc_getPhieuKhamBenhTheoEmail", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/PhieuKhamBenhTheoEmailTheoDK")]
        [HttpGet]
        public IHttpActionResult PhieuKhamBenhTheoEmailTheoDK(string dieukien, string email_user)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("dieukien", dieukien);
                param.Add("email_user", email_user);
                DataTable result = Database.Database.ReadTable("proc_getPhieuKhamBenhTheoEmailTheoDK", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }



        [Route("api/DataController/GetDoanhThu")]
        [HttpGet]
        public IHttpActionResult GetDoanhThu(string ngaybatdau,string ngayketthuc)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("ngaybatdau", ngaybatdau);
                param.Add("ngayketthuc", ngayketthuc);
                DataTable result = Database.Database.ReadTable("proc_getDoanhThu", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }
        [Route("api/DataController/GetDoanhThu1")]
        [HttpGet]
        public IHttpActionResult GetDoanhThu1(string ngaybatdau, string ngayketthuc)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("ngaybatdau", ngaybatdau);
                param.Add("ngayketthuc", ngayketthuc);
                DataTable result = Database.Database.ReadTable("proc_getDoanhThu1", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        [Route("api/DataController/InsertKhoa")]
        [HttpGet]
        public IHttpActionResult InsertKhoa(string ten_chuyen_khoa,string hinh)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("ten_chuyen_khoa",ten_chuyen_khoa);
                param.Add("hinh", hinh);
                var result = Database.Database.Insert_Data("proc_insertKhoa", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        [Route("api/DataController/InsertBacSi")]
        [HttpGet]
        public IHttpActionResult InsertBacSi(string ho_ten,string gioi_tinh,string ngay_sinh,string chuyen_khoa,string email,string id_zoom,string pass_zoom)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("ho_ten", ho_ten);
                param.Add("gioi_tinh", gioi_tinh);
                param.Add("ngay_sinh", ngay_sinh);
                param.Add("chuyen_khoa", chuyen_khoa);
                param.Add("email", email);
                param.Add("id_zoom", id_zoom);
                param.Add("pass_zoom", pass_zoom);
                var result = Database.Database.Insert_Data("proc_insertBacSi", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/InsertLichKham")]
        [HttpGet]
        public IHttpActionResult InsertLichKham(string chuyen_khoa,string bac_si,string ngay,string thoi_gian,string phong_kham,string loai_hinh,double gia)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("chuyen_khoa", chuyen_khoa);
                param.Add("bac_si", bac_si);
                param.Add("ngay", ngay);
                param.Add("thoi_gian", thoi_gian);
                param.Add("phong_kham", phong_kham);
                param.Add("loai_hinh", loai_hinh);
                param.Add("gia", gia);
                var result = Database.Database.Insert_Data("proc_insertLichKham", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/InsertPhieuKhamBenh")]
        [HttpGet]
        public IHttpActionResult InsertPhieuKhamBenh(string email_user,int id_chi_tiet_lich_kham,string ma_phieu,int stt,string ngay_dat_lich,string bhyt)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("email_user", email_user);
                param.Add("id_chi_tiet_lich_kham", id_chi_tiet_lich_kham);
                param.Add("ma_phieu", ma_phieu);
                param.Add("stt", stt);
                param.Add("ngay_dat_lich", ngay_dat_lich);
                param.Add("bhyt", bhyt);
                var result = Database.Database.Insert_Data("proc_insertPhieuKhamBenh", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/UpdateBacSi")]
        [HttpGet]
        public IHttpActionResult UpdateBacSi(int id,string ho_ten, string gioi_tinh, string ngay_sinh, string chuyen_khoa, string email, string id_zoom, string pass_zoom)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("id", id);
                param.Add("ho_ten", ho_ten);
                param.Add("gioi_tinh", gioi_tinh);
                param.Add("ngay_sinh", ngay_sinh);
                param.Add("chuyen_khoa", chuyen_khoa);
                param.Add("email", email);
                param.Add("id_zoom", id_zoom);
                param.Add("pass_zoom", pass_zoom);
                var result = Database.Database.Update_Data("proc_updateBacSi", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/UpdateLichKham")]
        [HttpGet]
        public IHttpActionResult UpdateLichKham(int id, string ngay, string thoi_gian, string phong_kham, string loai_hinh, double gia)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("id", id);
                param.Add("ngay", ngay);
                param.Add("thoi_gian", thoi_gian);
                param.Add("phong_kham", phong_kham);
                param.Add("loai_hinh", loai_hinh);
                param.Add("gia", gia);
                var result = Database.Database.Update_Data("proc_updateLichKham", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }


        [Route("api/DataController/UpdateChiTietLichKham")]
        [HttpGet]
        public IHttpActionResult UpdateChiTietLichKham(int id, string gio)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("id", id);
                param.Add("gio", gio);
                var result = Database.Database.Update_Data("proc_updateChiTietLichKham", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/DeleteBacSi")]
        [HttpGet]
        public IHttpActionResult DeleteBacSi(int id)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("id", id);
                var result = Database.Database.Delete_Data("proc_deleteBacSi", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/DataController/DeleteLichKham")]
        [HttpGet]
        public IHttpActionResult DeleteLichKham(int id)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("id", id);
                var result = Database.Database.Delete_Data("proc_deleteLichKham", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
