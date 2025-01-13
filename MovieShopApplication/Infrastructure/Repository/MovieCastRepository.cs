using ApplicationCore.Contracts;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastruture.Repository;

public class MovieCastRepository: BaseRepository<MovieCast>, IMovieCastRepository
{
    public MovieCastRepository(MovieDbContext movieDbContext):base(movieDbContext)
    {
    }
}