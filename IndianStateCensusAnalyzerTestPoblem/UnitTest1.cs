using IndianStateCensusAnalyzerProblem;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace IndianStateCensusAnalyzerTestPoblem
{
    public class Tests
    { 
        public string stateCencusFilePath = @"E:\Bridgelabz\IndianStatesCensusAnalyzerProblem\IndianStateCensusAnalyzerProblem\Files\StateCensusData.csv";
        public string stateCencusIncorrectFilePath = @"E:\Bridgelabz\IndianStatesCensusAnalyzerProblem\IndianStateCensusAnalyzerProblem\Files\StateData.csv";
        public string typeIncorrectFilePath = @"E:\Bridgelabz\IndianStatesCensusAnalyzerProblem\IndianStateCensusAnalyzerProblem\Files\DemoTxt.txt";
        public string delimeterFilePath = @"E:\Bridgelabz\IndianStatesCensusAnalyzerProblem\IndianStateCensusAnalyzerProblem\Files\CSVStateCencusDelimeter.csv";
        

        public void GivenStateCencusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            IndianCencusAnalyzer analyzerProblem = new IndianCencusAnalyzer();
            CSVStateCencus cSVState = new CSVStateCencus();
            Assert.AreEqual(cSVState.ReadStateCensusData(stateCencusFilePath), analyzerProblem.ReadStateCensusData(stateCencusFilePath));
        }
        [Test] 
        public void GivenStateCencusDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(stateCencusIncorrectFilePath);
            }
            catch(StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }

        }
        [Test] 
        public void GivenStateCencusDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(typeIncorrectFilePath);
            }
            catch (StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Type Incorrect");
            }
        }  
        
        [Test]        
        public void GivenStateCencusDataFileDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(delimeterFilePath);
            }
            catch (StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delimeter");
            }
        }

        [Test]
        public void GivenStateCencusDataFileHeaderIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer indianCencusAnalyzer = new IndianCencusAnalyzer();
            try
            {
                bool records = indianCencusAnalyzer.ReadStateCencusData(delimeterFilePath, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(records);
            }
            catch (StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
    }
}