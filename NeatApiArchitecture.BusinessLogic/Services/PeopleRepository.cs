using Microsoft.EntityFrameworkCore;
using NeatApiArchitecture.DataAccess.Context;
using NeatApiArchitecture.DomainCommons.Enteties;
using NeatApiArchitecture.DomainCommons.Interfaces;

namespace NeatApiArchitecture.BusinessLogic.Services;

public class PeopleRepository : IRepository<Person>
{
    private readonly PeopleContext _context;

    public PeopleRepository(PeopleContext context)
    {
        _context = context;
    }
    public async Task<Person?> GetByIdAsync(int id)
    {
        return await _context.People.FindAsync(id);
    }

    public async Task<IEnumerable<Person>> GetAllAsync()
    {
        return await _context.People.ToListAsync();
    }

    public async Task<Person> AddAsync(Person entity)
    {
        await _context.People.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Person UpdateAsync(Person entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
        return entity;
    }

    public void Delete(Person entity)
    {
        _context.People.Remove(entity);
        _context.SaveChanges();
    }
}