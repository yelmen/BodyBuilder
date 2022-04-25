using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Business.Abstract;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.ComplexTypes;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Concrete.Managers
{
    public class CustomerManager:ICustomerService
    {
        public enum FitTypes
        {
            BodyBuild,
            Starter,
            LosingWeight,
            Special
            
        }

        private ICustomerDal _customerDal;
        private IProgramDal _programDal;
        private ITrainDal _trainDal;


        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public CustomerManager(ICustomerDal customerDal,IProgramDal programDal, ITrainDal trainDal)
        {
            _customerDal = customerDal;
            _programDal = programDal;
            _trainDal = trainDal;
        }

        public List<WorkProgram> GetPrograms()
        {
            return _customerDal.GetPrograms();
        }

        public List<WorkProgram> GetProgramsByKey(string key)
        {
            return _customerDal.GetProgramsByKey(key);
        }
        public List<WorkProgram> GetProgramsByCustomerId(int customerId,string dayName = null)
        {
            return dayName == null ? _customerDal.GetProgramsByCustomerId(customerId) : _customerDal.GetProgramsByCustomerId(customerId,dayName);
        }

        public List<WorkProgram> GetDaysByCustomerId(int customerId)
        {
            return _customerDal.GetDaysByCustomerId(customerId);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return filter == null ? _customerDal.GetList() : _customerDal.GetList(filter);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _customerDal.Get(filter);
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(x => x.CustomerId == id);
        }

        public Customer Add(Customer entity)
        {
            return _customerDal.Add(entity);
        }

        public Customer Add(Customer entity,FitTypes type)
        {
            if (type == FitTypes.Starter)
            {
                Customer result = _customerDal.Add(entity);
                BeginnerProgram(result);
                return result;
            }
            else if (type == FitTypes.BodyBuild)
            {
                Customer result = _customerDal.Add(entity);
                BodyBuildProgram(result);
                return result;
            }
            else if (type == FitTypes.LosingWeight)
            {
                Customer result = _customerDal.Add(entity);
                LosingWeightProgram(result);
                return result;
            }
            else
            {
                return _customerDal.Add(entity);
            }
        }

        public Customer Update(Customer entity)
        {
            return _customerDal.Update(entity);
        }

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        private void BeginnerProgram(Customer entity)
        {
            if (_programDal != null)
            {
                List<string> firstDayList = new List<String>()
                {
                    "Bench-Press Machine",
                    "Dumbell Fly",
                    "Triceps-Pushdown",
                    "Triceps-Cable Pushdown",
                    "Shoulder Press",
                    "Lateral-Raise"
                };
                Dictionary<string, string> firstDayAvailable = new Dictionary<string, string>()
               {
                   {"Bench-Press Machine","3x12"},
                   {"Dumbell Fly","3x12"},
                   {"Triceps-Pushdown","3x12"},
                   {"Triceps-Cable Pushdown","3x12"},
                   {"Shoulder Press","3x12"},
                   {"Lateral-Raise","3x12"},

               };

                List<string> secondDayList = new List<String>()
                {
                    "Lat-Pulldown",
                    "Machine Row",
                    "Dumbell Curl",
                    "Barbell Curl",
                    "Leg Extension",
                    "Leg Curl"
                };
                Dictionary<string, string> secondDayAvailable = new Dictionary<string, string>()
                {
                    {"Lat-Pulldown","3x12"},
                    {"Machine Row","3x12"},
                    {"Dumbell Curl","3x12"},
                    {"Barbell Curl","3x12"},
                    {"Leg Extension","3x12"},
                    {"Leg Curl","3x12"},
                };

                List<string> thirdDayList = new List<String>()
                {
                    "Off"
                };

                if (10 <= entity.CustomerAge && 20 >= entity.CustomerAge && 
                    entity.CustomerWeight >= 50.0 && entity.CustomerWeight <= 100.0 &&
                    entity.CustomerSize >= 1.50 && entity.CustomerSize <= 1.85)
                {
                    ListLoop(1,firstDayList,entity,firstDayAvailable);
                    ListLoop(2,secondDayList,entity,secondDayAvailable);
                    ListLoop(3,thirdDayList,entity);

                } 
            }
            
        }

        private void LosingWeightProgram(Customer entity)
        {
            if (_programDal != null)
            {
                List<string> firstDayList = new List<String>()
                {
                    "Bench-Press Machine",
                    "Dumbell Fly",
                    "Triceps-Pushdown",
                    "Triceps-Cable Pushdown",
                    "Shoulder Press",
                    "Lateral-Raise",
                    "Kosu Bandi",
                    "Bisiklet"

                };
                Dictionary<string, string> firstDayAvailable = new Dictionary<string, string>()
                {
                    {"Bench-Press Machine","3x12"},
                    {"Dumbell Fly","3x12"},
                    {"Triceps-Pushdown","3x12"},
                    {"Triceps-Cable Pushdown","3x12"},
                    {"Shoulder Press","3x12"},
                    {"Lateral-Raise","3x12"},
                    {"Bisiklet","15d"},
                    {"Kosu Bandi","15d"},

                };

                List<string> secondDayList = new List<String>()
                {
                    "Lat-Pulldown",
                    "Machine Row",
                    "Dumbell Curl",
                    "Barbell Curl",
                    "Leg Extension",
                    "Leg Curl",
                    "Eliptik Bisiklet",
                    "Ip Atlama"

                };
                Dictionary<string, string> secondDayAvailable = new Dictionary<string, string>()
                {
                    {"Lat-Pulldown","3x12"},
                    {"Machine Row","3x12"},
                    {"Dumbell Curl","3x12"},
                    {"Barbell Curl","3x12"},
                    {"Leg Extension","3x12"},
                    {"Leg Curl","3x12"},
                    {"Eliptik Bisiklet","15d"},
                    {"Ip Atlama","2 bin"},

                };

                List<string> thirdDayList = new List<String>()
                {
                    "Kosu Bandi",
                    "Eliptik Bisiklet",
                    "Bisiklet",
                    "Ip Atlama",
                    "Crunch"
                };
                Dictionary<string, string> thirdDayAvailable = new Dictionary<string, string>()
                {
                    {"Kosu Bandi","20d"},
                    {"Eliptik Bisiklet","20d"},
                    {"Bisiklet","20d"},
                    {"Ip Atlama","3 bin"}
                };

                List<string> fourthDayList = new List<string>()
                {
                    "Off"
                };

                if (10 <= entity.CustomerAge && 30 >= entity.CustomerAge &&
                    entity.CustomerWeight >= 80.0 &&
                    entity.CustomerSize >= 1.50 && entity.CustomerSize <= 1.90)
                {
                    ListLoop(1, firstDayList, entity,firstDayAvailable);
                    ListLoop(2, secondDayList, entity,secondDayAvailable);
                    ListLoop(3, thirdDayList, entity, thirdDayAvailable);
                    ListLoop(1001, fourthDayList, entity);

                }
            }

        }


        private void BodyBuildProgram(Customer entity)
        {
            if (_programDal != null)
            {
                List<string> firstDayList = new List<String>()
                {
                    "Bench-Press",
                    "Incline-Bench Press",
                    "Dumbell Fly",
                    "Incline Dumbell Fly",
                    "Dumbell Benc-Press",
                    "Dips",
                    "Triceps-Cable Pushdown",
                    "Dumbell Kick-Back",
                    "Triceps-Pushdown"
                };
                Dictionary<string, string> firstDayAvailable = new Dictionary<string, string>()
                {
                    {"Dumbell Fly","4x12"},
                    {"Triceps-Cable Pushdown","4x12"},
                    {"Triceps-Pushdown","5x12"}

                };

                List<string> secondDayList = new List<String>()
                {
                    "Pull Down",
                    "Lat-Pulldown",
                    "Dumbell Row",
                    "Machine Row",
                    "Barbell Row",
                    "Barbell Curl",
                    "Dumbell Curl",
                    "Hummer Curl",
                    "Barbell Scoth"
                };
                Dictionary<string, string> secondDayAvailable = new Dictionary<string, string>()
                {
                    {"Lat-Pulldown","4x12"},
                    {"Machine Row","4x15"},
                    {"Barbell Curl","4x12"},
                    {"Dumbell Curl","4x12"}
                };

                List<string> thirdDayList = new List<String>()
                {
                    "Barbell Shoulder Press",
                    "Dumbell Shoulder Press",
                    "Lateral-Raise",
                    "Front Raise",
                    "Reverse Machine Fly",
                    "Squat",
                    "Lunge",
                    "Leg Press",
                    "Leg Extension",
                    "Leg Curl",
                    "Calf Raise"
                };
                Dictionary<string, string> thirdDayAvailable = new Dictionary<string, string>()
                {
                    {"Lateral-Raise","4x12"},
                    {"Leg Extension","4x12"},
                    {"Leg Curl","4x12"}
                };

                List<string> fourthDayList = new List<string>()
                {
                    "Off"
                };

                if (10 <= entity.CustomerAge && 30 >= entity.CustomerAge &&
                    entity.CustomerWeight >= 40.0 && entity.CustomerWeight <= 80.0 &&
                    entity.CustomerSize >= 1.50 && entity.CustomerSize <= 1.85)
                {
                    ListLoop(1, firstDayList, entity,firstDayAvailable);
                    ListLoop(2, secondDayList, entity,secondDayAvailable);
                    ListLoop(3, thirdDayList, entity,thirdDayAvailable);
                    ListLoop(1001, fourthDayList, entity,thirdDayAvailable);

                }
            }

        }
        
        




        private void ListLoop(int dayid,List<string> workList,Customer entity,Dictionary<string,string> available = null)
        {
            foreach (var workName in workList)
            {
                if (available == null)
                {
                    _programDal.Add(new Program()
                    {
                        CustomerId = entity.CustomerId,
                        DayId = dayid,
                        TrainingId = _trainDal.Get(x => x.TrainingName == workName).TrainingId
                    });
                }
                else
                {
                    if (available.ContainsKey(workName))
                    {
                        string amount = available[workName];
                        _programDal.Add(new Program()
                        {
                            CustomerId = entity.CustomerId,
                            DayId = dayid,
                            TrainingId = _trainDal.Get(x => x.TrainingName == workName && x.WorkAmount == amount).TrainingId
                        });
                    }
                    else
                    {
                        _programDal.Add(new Program()
                        {
                            CustomerId = entity.CustomerId,
                            DayId = dayid,
                            TrainingId = _trainDal.Get(x => x.TrainingName == workName).TrainingId
                        });
                    }
                    
                }
                
            }
        }

       
    }

    
}
