using System;

namespace Kanban.Features.Common.Models
{
    public readonly struct Identifier
    {
        public string Id { get; init; }

        public Identifier(string id)
        {
            Id = id;
        }

        public static Identifier New() => new Identifier(Guid.NewGuid().ToString());

        public override string ToString() => Id;
    }
}