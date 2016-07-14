using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Day5WebApiHomework.Models;

namespace Day5WebApiHomework.Models
{
    public static class SampleDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationContext>();

            if (!context.Trains.Any())
            {
                var Train1 = new Train
                {
                    TrainNum = 1
                };

                for (int i = 0; i < 10; i++)
                {
                    Train1.Railcars.Add(new Railcar
                    {
                        RailcarNum = i,
                        TrainId = 1
                    });
                }


                foreach (Railcar railcar in Train1.Railcars)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        railcar.Places.Add(new Place
                        {
                            RailcarId = i,
                            Cost = 100 * i
                        });
                    }

                }



                context.Trains.Add(Train1);

                context.SaveChanges();
            }
        }
    }
}
