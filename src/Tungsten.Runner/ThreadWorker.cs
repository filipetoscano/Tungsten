using System;
using System.Threading;
using System.Threading.Tasks;
using Platinum.Configuration;

namespace Tungsten.Runner
{
    public class ThreadWorker
    {
        /// <summary>
        /// Starts the worker thread.
        /// </summary>
        public async void Run( CancellationToken token )
        {
            #region Validations

            if ( token == null )
                throw new ArgumentNullException( nameof( token ) );

            #endregion

            var delayWork = TimeSpan.FromMilliseconds( AppConfiguration.Get<int>( "SleepTime.Work[ms]" ) );
            var delayNoWork = TimeSpan.FromMilliseconds( AppConfiguration.Get<int>( "SleepTime.NoWork[ms]" ) );

            while ( true )
            {
                /*
                 * Check if work is available.
                 */

                


                await Task.Delay( delayNoWork, token );
            }
        }
    }
}
