using OceanLibrary;

namespace OceanGame.Subscriber
{
    class SubscriberCountCell
    {
        private int _preyCount = 0;
        private int _predatorCount = 0;
        private int _offset;
        private int _oceanHeight;

        public SubscriberCountCell(Ocean publisher, int offset)
        {
            _oceanHeight = publisher.Height;
            _offset = offset;
            
            publisher.AddedCell += CountAddedCellDelegate;
            publisher.RemovedCell += CountRemovedCellDelegate;
        }

        public int PreyCount
        {
            get
            {
                return _preyCount;
            }
        }

        public int PredatorCount
        {
            get
            {
                return _predatorCount;
            }
        }

        private void CountAddedCellDelegate(object sender, ChangedCellEventArgs args)
        {
            if (args.Target is Predator)
            {
                _predatorCount++;
            }
            else if (args.Target is Prey && !(args.Target is Predator))
            {
                _preyCount++;
            }

            OceanConsoleVeiwer.ShowResult(_predatorCount, _preyCount, _offset, _oceanHeight);
        }

        private void CountRemovedCellDelegate(object sender, ChangedCellEventArgs args)
        {
            if (args.Target is Predator)
            {
                _predatorCount--;
            }
            else if (args.Target is Prey && !(args.Target is Predator))
            {
                _preyCount--;
            }

            OceanConsoleVeiwer.ShowResult(_predatorCount, _preyCount, _offset, _oceanHeight);
        }
    }
}
