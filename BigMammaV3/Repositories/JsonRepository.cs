using BigMammaV3.Interfaces;

namespace BigMammaV3.Repositories;

public class JsonRepository<T> : IRepository<T>
{
    private readonly IJsonService _jsonService;
    private readonly string? _filepath;

    private Dictionary<int, T>? _entities;

    public Dictionary<int, T> Entities
    {
        get
        {
            if (_entities == null)
            {
                Load();
            }
            if (_entities == null) { throw new InvalidDataException(); }
            return _entities;
        }
        set { _entities = value; }
    }

    public JsonRepository(IJsonService jsonService, string filepath)
    {
        _jsonService = jsonService;
        _filepath = filepath;
    }

    public void Add(T entity)
    {
        Entities.Add(GetNextId(), entity);
        Save();
    }
    public void Remove(int id)
    {
        Entities.Remove(id);
        Save();
    }
    public T Get(int id)
    {
        return Entities.GetValueOrDefault(id);
    }
    public bool Update(int id, T entity)
    {
        bool updatePossible;
        if(!Entities.ContainsKey(id)) { return false; }

        Entities[id] = entity;
        Save();

        return true;
    }
    private int GetNextId()
    {
        int id = 1;
        if (Entities.Any())
        {
            id = Entities.Keys.Max() + 1;
        }
        return id;
    }

    public void Save()
    {
        _jsonService.Write(_filepath, Entities);
    }
    public void Load()
    {
        try
        {
            Entities = _jsonService.Read<Dictionary<int, T>>(_filepath) ?? throw new InvalidDataException($"Could not load {_filepath}");
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine(ex.Message);
            Entities = new Dictionary<int, T>();
        }

    }
}