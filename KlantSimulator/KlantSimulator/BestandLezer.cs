using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantSimulator
{
    public class BestandLezer
    {
        public List<string> DataList(string pad) {
            List<string> data = new();
            using (StreamReader sr = new(pad)) {
                string line = "";
                while ((line = sr.ReadLine()) != null) {
                    line = line.Trim(); // No need to call ReadLine() again
                    data.Add(line);
                }
            }
            return data;
        }

        public Dictionary<int, string> DataDictionary(string pad) {
            Dictionary<int, string> data = new();
            string dataString = null;
            using (StreamReader sr = new(pad)) {
                dataString = sr.ReadToEnd();
            }
            string[] dataArray = dataString.Split(',');
            foreach(var dataVar in dataArray) {
                string[] splitBySpace = dataVar.Split(' ');
                data.Add(int.Parse(splitBySpace[0]), splitBySpace[1]);
            }
            return data;
        }
        public List<string> StraatNamenData(string pad) {
            List<string> data = new();
            using (StreamReader sr = new(pad)) {
                string line;
                while(sr.ReadLine() != null) {
                    line = sr.ReadLine();
                    string[] waarden = line.Split(',');
                    data.Add(waarden[2]);
                }
            }
            return data;
        }
    }
}
