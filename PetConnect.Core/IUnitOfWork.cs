using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConnect.Core
{
    public interface IUnitOfWork
    {
        public interface IUnitOfWork
        {
            //IAppUserRepository Users { get; }
            //ICollectionRepository Collections { get; }
            //IAlbumRepository Albums { get; }

            void Commit();
        }
    }
}
