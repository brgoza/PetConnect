using PetConnect.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConnect.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context = null!;
        //private AppUserRepository _userRepository = null!;
        //private CollectionRepository _collectionRepository = null!;
        //private AlbumRepository _albumRepository = null!;
        //private PhotoRepository _photoRepository = null!;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        //public IAppUserRepository Users => _userRepository ??= new AppUserRepository(_context);
        //public ICollectionRepository Collections => _collectionRepository ??= new CollectionRepository(_context);
        //public IAlbumRepository Albums => _albumRepository ??= new AlbumRepository(_context);
        //public IPhotoRepository Photos => _photoRepository ??= new PhotoRepository(_context);
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
