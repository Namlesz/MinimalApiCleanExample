namespace Todos.Services;

internal static class TodoGenerator
{
    private static readonly (string[] Prefixes, string[] Suffixes)[] Parts =
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
        var titleMap = Parts.SelectMany((part, i) =>
            part.Prefixes.SelectMany((_, j) =>
                part.Suffixes.Select((_, k) => (Row: i, Prefix: j, Suffix: k)))
        ).ToArray();

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