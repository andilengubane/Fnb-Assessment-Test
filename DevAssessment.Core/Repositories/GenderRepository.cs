using DevAssessment.Core.Interfaces;
using DevAssessment.EntityFramework.Context;

namespace DevAssessment.Core.Repositories
{
    public class GenderRepository : Repository<Gender>,  IGenderRepository
    {
        private DevAssessmentEntities _context;

        public GenderRepository(DevAssessmentEntities context) : base(context)
        {
            _context = context;
        }
    }
}