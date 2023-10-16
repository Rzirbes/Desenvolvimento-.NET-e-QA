using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Context;
using DesafioApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DesafioApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ToDoItemController : ControllerBase
    {
        private readonly DataContext _context;

        public ToDoItemController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(ToDoItem contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.ToDoItems.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string title)
        {
            var contato = _context.ToDoItems.Where(x => x.Title.Contains(title));
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var contatos = _context.ToDoItems;
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, ToDoItem task)
        {
            var taskBanco = _context.ToDoItems.Find(id);

            if (taskBanco == null)
                return NotFound();

            taskBanco.Title = task.Title;
            taskBanco.Description = task.Description;
            taskBanco.Date = task.Date;
            taskBanco.Status = task.Status;

            _context.ToDoItems.Update(taskBanco);
            _context.SaveChanges();

            return Ok(taskBanco);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(StatusType status)
        {
            var tarefa = _context.ToDoItems.Where(x => x.Status == status);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.ToDoItems.Where(x => x.Date.Date == data.Date);
            return Ok(tarefa);
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contato = _context.ToDoItems.Find(id);

            if (contato == null)
                return NotFound();

            _context.ToDoItems.Remove(contato);
            _context.SaveChanges();

            return NoContent();
        }


    }
}