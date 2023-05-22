using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.Contract.Persistence;
using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_Persistence.Repositories.Blogs;
using BackEnd_Persistence.Repositories.GeneralInformations;
using System;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly RealEstateDbContext _context;
        private ISocialRepository _socialRepository;
        private IBlogContentRepository _blogContentRepository;
        private IBlogGroupRepository _blogGroupRepository;
        private IAboutUsRepository _aboutUsRepository;
        private IAddressRepository _addressRepository;
        private ILogoRepository _logoRepository;
        private IBannerRepository _bannerRepository;
        private ICommonQuestionRepository _commonQuestionRepository;
        private IConstructorInfromationRepository _constructorInfromationRepository;
        private IRealEstateServicesRepository _realEstateServicesRepository;
        private ISpectacularlocationRepository _spectacularlocationRepository;

        public UnitOfWork(RealEstateDbContext context) => _context = context;


        public ISocialRepository SocialRepository => _socialRepository ??= new SocialRepository(_context);
        public IBlogContentRepository BlogContentRepository => _blogContentRepository ??= new BlogContentRepository(_context);
        public IBlogGroupRepository BlogGroupRepository => _blogGroupRepository ??= new BlogGroupRepository(_context);
        public IAboutUsRepository AboutUsRepository => _aboutUsRepository ??= new AboutUsRepository(_context);
        public IAddressRepository AddressRepository => _addressRepository ??= new AddressRepository(_context);
        public ILogoRepository LogoRepository => _logoRepository ??= new LogoRepository(_context);
        public IBannerRepository BannerRepository => _bannerRepository ??= new BannerRepository(_context);
        public ICommonQuestionRepository CommonQuestionRepository => _commonQuestionRepository ??= new CommonQuestionRepository(_context);
        public IConstructorInfromationRepository ConstructorInfromationRepository => _constructorInfromationRepository ??= new ConstructorInfromationRepository(_context);
        public IRealEstateServicesRepository RealEstateServicesRepository => _realEstateServicesRepository ??= new RealEstateServicesRepository(_context);
        public ISpectacularlocationRepository SpectacularlocationRepository => _spectacularlocationRepository ??= new SpectacularlocationRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
