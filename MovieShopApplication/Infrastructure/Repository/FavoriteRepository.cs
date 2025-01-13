using ApplicationCore.Contracts;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastruture.Repository;

public class FavoriteRepository:BaseRepository<Favorite>, IFavoriteRepository
{
    public FavoriteRepository(MovieDbContext movieDbContext): base(movieDbContext)
    {
    }
}