using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDesinationCommand command)
        {
            var values = _context.Destinations.Find(command.ID);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
