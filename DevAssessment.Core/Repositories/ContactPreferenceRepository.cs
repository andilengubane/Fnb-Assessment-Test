using DevAssessment.Core.Interfaces;
using DevAssessment.EntityFramework.Context;

namespace DevAssessment.Core.Repositories
{
    public class ContactPreferenceRepository : Repository<ContactPreferance>, IContactPreferenceRepository
    {
        private DevAssessmentEntities _context;

        public ContactPreferenceRepository(DevAssessmentEntities context): base(context)
        {
            _context = context;
        }
    }
}