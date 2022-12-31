using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTT
{
    class GetGrade
    {
        public Nullable<int> الرقم { get; set; }
        public string اسم_الطالب { get; set; }
        public Nullable<int> درجة_اعمال_الفصل_ { get; set; }
        public Nullable<int> درجة_الامتحان_النهائي { get; set; }
        public Nullable<int> الدرجة_النهائية { get; set; }
        public int uid { get; set; }
    }
}
