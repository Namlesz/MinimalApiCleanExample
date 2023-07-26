namespace Todos.Services;

internal static class TodoGenerator
{
    private readonly static (string[] Prefixes, string[] Suffixes)[] Parts =
    {
        (new[]
        {
            "Walk the", "Feed the"
        }, new[]
        {
            "dog", "cat", "goat"
        }),
        (new[]
        {
            "Do the", "Put away the"
        }, new[]
        {
            "groceries", "dishes", "laundry"
        }),
        (new[]
        {
            "Clean the"
        }, new[]
        {
            "bathroom", "pool", "blinds", "car"
        })
    };

    internal static IEnumerable<Models.Todos> GenerateTodos(int count = 5)
    {
        var titleCount = Parts.Sum(row => row.Prefixes.Length * row.Suffixes.Length);
        var titleMap = new (int Row, int Prefix, int Suffix)[titleCount];
        var mapCount = 0;
        for (var i = 0; i < Parts.Length; i++)
        {
            var prefixes = Parts[i].Prefixes;
            var suffixes = Parts[i].Suffixes;
            for (var j = 0; j < prefixes.Length; j++)
            for (var k = 0; k < suffixes.Length; k++)
                titleMap[mapCount++] = (i, j, k);
        }

        Random.Shared.Shuffle(titleMap);

        for (var id = 1; id <= count; id++)
        {
            var (rowIndex, prefixIndex, suffixIndex) = titleMap[id];
            var (prefixes, suffixes) = Parts[rowIndex];
            yield return new Models.Todos
            {
                Id = id,
                Title = string.Join(' ', prefixes[prefixIndex], suffixes[suffixIndex]),
                DueBy = Random.Shared.Next(-200, 365) switch
                {
                    < 0 => null,
                    var days => DateOnly.FromDateTime(DateTime.Now.AddDays(days))
                }
            };
        }
    }
}