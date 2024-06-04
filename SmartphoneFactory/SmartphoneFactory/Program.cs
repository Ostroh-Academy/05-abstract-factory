using SmartphoneFactory.Factories;

namespace SmartphoneFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartphoneFactory performanceFactory = new PerformanceSmartphoneFactory();
            Client performanceClient = new Client(performanceFactory);
            performanceClient.Run();

            ISmartphoneFactory cameraFactory = new CameraSmartphoneFactory();
            Client cameraClient = new Client(cameraFactory);
            cameraClient.Run();
        }
    }
}
