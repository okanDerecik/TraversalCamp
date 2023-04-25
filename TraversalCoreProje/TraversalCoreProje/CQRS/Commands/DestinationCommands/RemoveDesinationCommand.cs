namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class RemoveDesinationCommand
    {
        public RemoveDesinationCommand(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
