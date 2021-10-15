using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonka.Core.Model.Common
{
    public interface ICatalogue
    {
        public int Id { get; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
