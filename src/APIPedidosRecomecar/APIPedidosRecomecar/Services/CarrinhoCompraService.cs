using APIPedidosRecomecar.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace APIPedidosRecomecar.Services
{
    public class CarrinhoCompraService
    {
       
            private readonly IMongoCollection<CarrinhoCompra> _carrinhoCompraCollection;
            public CarrinhoCompraService(IOptions<RecomecarDatabaseSettings> recomecarDatabaseSettings)
            {
                var mongoClient = new MongoClient(
                    recomecarDatabaseSettings.Value.ConnectionString);
                var mongoDatabase = mongoClient.GetDatabase(
                    recomecarDatabaseSettings.Value.DatabaseName);
                _carrinhoCompraCollection = mongoDatabase.GetCollection<CarrinhoCompra>(
                    recomecarDatabaseSettings.Value.CarrinhoCompraCollectionName);
            }

            public async Task<CarrinhoCompra?> GetCarrinhoCompraByUserIdAsync(ulong id) =>
                await _carrinhoCompraCollection.Find(x => x.UserId == id).FirstOrDefaultAsync();

            public async Task CreateCarrinhoCompraAsync(CarrinhoCompra newCarrinhoCompra) =>

                await _carrinhoCompraCollection.InsertOneAsync(newCarrinhoCompra);



        
    }
}
