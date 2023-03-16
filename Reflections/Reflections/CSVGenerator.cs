using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Reflection;

namespace Reflections
{
    public class CSVGenerator<T>
    {
        public IEnumerable<T> data;
        public string filename;
        public Type type;

        public CSVGenerator(IEnumerable<T> data, string filename)
        {
            this.data = data;
            this.filename = filename;
            this.type = typeof(T);

        }
        public void Generate()
        {
            List<string> rows = new List<string>();

            rows.Add(CreateHeader());

            foreach(var item in data)
            {
                rows.Add(CreateRow(item));
            }

            File.WriteAllLines($"{filename}.csv", rows, Encoding.UTF8);
        }

        public string CreateHeader() {

            var strb = new StringBuilder();

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var ordered_properties = properties.OrderBy(p => p.GetCustomAttribute<ReportItemAttribute>().ColOrder);


            foreach (var property in properties)
            {
                var attr = property.GetCustomAttribute<ReportItemAttribute>();
                strb.Append(attr.Heading ?? property.Name).Append(",");
            }
            return strb.ToString()[..^1];
        }

        public string CreateRow(T item)
        {
            var strb = new StringBuilder();

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //sort by Column order before entering into the array so that the order when writing into file is maintained 

            var ordered_properties = properties.OrderBy(p => p.GetCustomAttribute<ReportItemAttribute>().ColOrder);

            foreach (var property in properties)
            {
                var attr = property.GetCustomAttribute<ReportItemAttribute>();
                strb.Append(CreateItem((dynamic)property.GetValue(item)) + attr.Units ?? "").Append(",");
            }
            return strb.ToString()[..^1];
        }

        public string CreateItem(object str) => str.ToString(); 
        public string CreateItem(DateTime dt) => dt.ToShortDateString(); 
    }
}
