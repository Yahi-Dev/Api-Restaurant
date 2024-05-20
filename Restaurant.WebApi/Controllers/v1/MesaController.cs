using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Interfaces.Services;
using Restaurant.Core.Application.ViewModels.Mesa;
using Restaurant.Core.Application.ViewModels.Orden;

namespace Restaurant.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class MesaController : BaseApiController
    {
        private readonly IMesaService _mesaService;

        public MesaController(IMesaService mesaService)
        {
            _mesaService = mesaService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MesaViewModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = "Mesero")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var mesas = await _mesaService.GetAllViewModel();

                if (mesas == null || mesas.Count == 0)
                {
                    return NoContent();
                }

                return Ok(mesas);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SaveMesaViewModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = "Mesero")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var mesa = await _mesaService.GetByIdSaveViewModel(id);

                if (mesa == null)
                {
                    return NoContent();
                }

                return Ok(mesa);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }







        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(SaveMesaViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                await _mesaService.Add(vm);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }





        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SaveMesaViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Put(int id, SaveMesaViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                await _mesaService.Update(vm, id);
                return Ok(vm);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        [HttpPost("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrdenViewModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = "Mesero")]
        public async Task<IActionResult> GetTableOrden(int id)
        {
            try
            {
                var mesas = await _mesaService.GetTableOrden(id);

                if (mesas == null)
                {
                    return NoContent();
                }

                return Ok(mesas);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = "Mesero")]
        public async Task<IActionResult> ChangeStatus(ChangeStatusMesaViewModel vm)
        {
            try
            {
                var mesas = await _mesaService.ChangeStatus(vm);

                if (mesas == false)
                {
                    return NoContent();
                }

                return Ok(mesas);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
