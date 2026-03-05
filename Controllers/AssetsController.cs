using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssetFlow.Api.Data;
using AssetFlow.Api.Models;

namespace AssetFlow.Api.Controllers;

[ApiController] // diz que essa classe é uma API
[Route("api/[Controller]")] //definindo a rota como 'api/assets'
public class AssetsController: ControllerBase 
//definindo que AssetsController é uma classe controllerBase que vai lidar com requisições HTTP
{
    private readonly AppDbContext _context;

    //construtor recebe o banco de dados que foi configurado em Program.cs
    public AssetsController(AppDbContext context)
    {
        _context = context;
    }

    //GET: api/assets
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Asset>>> GetAssets()
    {
        return await _context.Assets.ToListAsync();
    }

    //POST: api/assets
    [HttpPost]
    public async Task<ActionResult<Asset>> PostAsset(Asset asset)
    //asset asset -> recebe um json do nav e transforma automaticamente em asset
    {
        _context.Assets.Add(asset); //avisa que é para salvar
        await _context.SaveChangesAsync(); ///espera a confirmação q salvou
        return Ok(asset); //status code 200 + objeto criado

    }
}