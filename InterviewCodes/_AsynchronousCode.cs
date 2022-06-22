using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    class _AsynchronousCode
    {
        /**
         * Asynchronous (async) programming lets you execute a block of code without stopping
         * (or blocking) the entire thread where the action is being executed. A common myth
         * about async code is that it improves performance, which isn't necessarily true.
         *
         * Instead. the major perk of  async programming is - it increases the number of tasks
         * that can be executed concurrently.
         */

        //Synchronus cake program
        public void MakeCake()
        {
            PreheatOven();
            AddCakeIngredients();
            BakeCake();
            AddFrostingIngredients();
            CoolFrosting();
            CoolCake();
            FrostCake();

            Console.WriteLine("Cake is served! Bon Appetits!");
        }

        //Asynchronous cake program
        public async Task MakeCakeAsync()
        {
            Task<bool> preheatTask = PreheatOvenAsync();
            AddCakeIngredients();
            bool isPreheated = await preheatTask;

            //and so on....
        }

        private Task<bool> PreheatOvenAsync()
        {
            throw new NotImplementedException();
        }

        #region Cake functions 

        private void FrostCake()
        {
            throw new NotImplementedException();
        }

        private void CoolCake()
        {
            throw new NotImplementedException();
        }

        private void CoolFrosting()
        {
            throw new NotImplementedException();
        }

        private void AddFrostingIngredients()
        {
            throw new NotImplementedException();
        }

        private void BakeCake()
        {
            throw new NotImplementedException();
        }

        private void AddCakeIngredients()
        {
            throw new NotImplementedException();
        }

        private void PreheatOven()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
