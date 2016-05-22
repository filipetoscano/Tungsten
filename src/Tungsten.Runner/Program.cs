using Topshelf;

namespace Tungsten.Runner
{
    class Program
    {
        static void Main( string[] args )
        {
            HostFactory.Run( x =>
            {
                x.Service<TungstenService>( s =>
                {
                    s.ConstructUsing( name => new TungstenService() );
                    s.WhenStarted( tc => tc.Start() );
                    s.WhenStopped( tc => tc.Stop() );
                } );

                x.RunAsLocalSystem();

                x.SetServiceName( "Tungsten" );
                x.SetDisplayName( "Tungsten" );
                x.SetDescription( "Tungsten process instance execution" );

                x.StartManually();
            } );
        }
    }
}
