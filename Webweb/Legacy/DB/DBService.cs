using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WebEntities.Models;
using Npgsql;
using Webweb.Models;

namespace Webweb.DB
{
    public class DBServiceDapper
    {
        //private string _connectionString {set;get;}

        //public DBServiceDapper(IConfiguration configuration) {
        //    _connectionString = configuration["db:dev"];
        //}

        //public IEnumerable<TraineeViewModel> GetTrainees() {
        //    var sql = "SELECT * FROM public.\"Trainees\"";
        //    using (var conn = new NpgsqlConnection(_connectionString)) {
        //        conn.Open();
        //        NpgsqlCommand trainees1 = new NpgsqlCommand(sql, conn);
        //        NpgsqlDataReader odk = trainees1.ExecuteReader();
        //        if (odk.HasRows) {
        //            List<TraineeViewModel> trainees = new List<TraineeViewModel>();
        //            while (odk.Read()) {
        //                var person = new TraineeViewModel();
        //                person.TraineeID = int.Parse(odk["trainEEID"].ToString());
        //                person.Age = int.Parse(odk["Age"].ToString());
        //                person.Belt = (BeltColor) int.Parse(odk["Belt"].ToString());
        //                person.Fullname = odk["Fullname"].ToString();

        //                trainees.Add(person);
        //            }

        //            return trainees;
        //        }

        //        return null;
        //    }
        //}
    }
}
