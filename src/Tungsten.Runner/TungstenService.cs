using Platinum.Configuration;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tungsten.Runner
{
    public class TungstenService
    {
        private List<Task> _workers;
        private CancellationTokenSource _tokenSource;


        /// <summary>
        /// Initializes a new instance of <see cref="TungstenService" /> class.
        /// </summary>
        public TungstenService()
        {
        }


        /// <summary>
        /// Starts the service, which will spawn all of the worker threads.
        /// </summary>
        public void Start()
        {
            int threadCount = AppConfiguration.Get<int>( "ThreadCount" );

            _workers = new List<Task>();
            _tokenSource = new CancellationTokenSource();

            for ( int i = 0; i < threadCount; i++ )
            {
                ThreadWorker tw = new ThreadWorker();
                Task t = Task.Run( () => tw.Run( _tokenSource.Token ) );
                _workers.Add( t );
            }
        }


        /// <summary>
        /// Requests that the service stops.
        /// </summary>
        public void Stop()
        {
            _tokenSource.Cancel();

            Task.WaitAll( _workers.ToArray() );
        }
    }
}
