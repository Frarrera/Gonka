using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonka.Core.Model.Common
{
    public interface ISoftDelete
    {
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }

        [NotMapped]
        public bool IsDeleted => DeletedAt.HasValue && !string.IsNullOrWhiteSpace(DeletedBy);
    }
}
