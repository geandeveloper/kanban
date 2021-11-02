using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.Features.Common.Models;
using Kanban.Features.Common.Repositories;
using MongoDB.Driver;

namespace Kanban.Features.Infrastructure.Repositories
{
    public class MongoRepository<T> : IKanbanRepository<T> where T : KanbanModel
    {
        private readonly IMongoDatabase _database;

        public MongoRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return (await _database.GetCollection<T>(typeof(T).Name).FindAsync(model => true)).ToEnumerable();
        }

        public async Task AddAsync(T model)
        {
            await _database.GetCollection<T>(typeof(T).Name).InsertOneAsync(model);
        }
    }
}