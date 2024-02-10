using Business.Concrete;
using Bussiness.Concrete;

namespace Workaround
{
    internal class PttManager
    {
        private ForeignerManager foreignerManager;

        public PttManager(ForeignerManager foreignerManager)
        {
            this.foreignerManager = foreignerManager;
        }

        internal void GiveMask(object person1)
        {
            throw new NotImplementedException();
        }
    }
}