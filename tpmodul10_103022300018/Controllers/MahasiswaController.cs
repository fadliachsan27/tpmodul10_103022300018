using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300018.Models;
using System.Collections.Generic;

namespace tpmodul10_103022300018.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // Static list mahasiswa
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Fadli Achsan K", "103022300018"), // <- ganti NamaKamu jadi nama kamu
            new Mahasiswa("Teman 1", "1302000002"),
            new Mahasiswa("Teman 2", "1302000003")
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetMahasiswa()
        {
            return daftarMahasiswa;
        }

        // GET: api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetMahasiswaByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            return daftarMahasiswa[index];
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult<List<Mahasiswa>> PostMahasiswa([FromBody] Mahasiswa mahasiswaBaru)
        {
            daftarMahasiswa.Add(mahasiswaBaru);
            return daftarMahasiswa;
        }

        // DELETE: api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}
