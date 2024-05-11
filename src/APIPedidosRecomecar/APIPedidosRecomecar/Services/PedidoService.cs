using APIPedidosRecomecar.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
namespace APIPedidosRecomecar.Services
{
    public class PedidoService
    {
        private readonly IMongoCollection<Pedido> _pedidoCollection;
        public PedidoService(IOptions<RecomecarDatabaseSettings> recomecarDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                recomecarDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(
                recomecarDatabaseSettings.Value.DatabaseName);
            _pedidoCollection = mongoDatabase.GetCollection<Pedido>(
                recomecarDatabaseSettings.Value.PedidoCollectionName);
        }
        public async Task<List<Pedido>> GetPedidosAsync()=>
            await _pedidoCollection.Find(_=>true).ToListAsync();

        public async Task<Pedido?> GetPedidosAsync(string id) =>
            await _pedidoCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Pedido newPedido) => 
            await _pedidoCollection.InsertOneAsync(newPedido);

        public async Task UpdateAsync(string id, Pedido updatedPedido) =>
            await _pedidoCollection.ReplaceOneAsync(x => x.Id == id, updatedPedido);

        public async Task RemoveAsync(string id) =>
            await _pedidoCollection.DeleteOneAsync(x => x.Id == id);
    }
}
