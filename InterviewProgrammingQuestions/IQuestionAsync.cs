using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgrammingQuestions
{
    internal interface IQuestionTaskAsync
    {
        Task Run();
    }

    internal interface IQuestionVoidAsync
    {
        void Run();
    }
}
