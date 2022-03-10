
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook( string name,bool isweight):base(name,isweight)
        {
            Type = GradeBookType.Standard;

        }
    }
}
