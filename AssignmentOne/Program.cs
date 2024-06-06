// See https://aka.ms/new-console-template for more information
//Name: Sasitha Ratnayake
// Assignment Name: Programming Fundementals Assignment1
// Date: Sunday June 2nd 2024
// Markdown restatement: I need to create a program that calculates the net pay, tax with-holding and monthly Gross pay based on the given inputs of Employee ID 
// hourly rate of pay and deductions and number of regular Hours and number of overtime hours worked. 
// they tell me that there Constant change of regular hours to overtime is a change of 1.5 meaning 1 overtime hour is 1.5 regular hours 
// then there needs to be a constant of tax rate of 30% of gross pay 
// regularPay = hourly rate * regularHours
// OvertimePay = OvertimeHours * hourlyRate * 1.5 
// grossPay= overtimePay + regularPay
// taxes = grossPay * 0.3 
// netPay  = grossPay- taxes - deductions
// Steps 
// Declare constant double TAXRATE= 0.3;
// Declare constant double CHANGEOFOVERTIMEHOURSOVERREGULARHOURSRATE= 1.5;
// Declare int EmployeeId;
// Declare double hourlyRate;
// Declare  double regularHours;
// Declare double overTimeHours;
// Declare double totalDeductionsForPayPeriod;
// // Declare string EmployeeIdString;
// Declare string hourlyRateString;
// Declare  string regularHoursString;
// Declare string overTimeHoursString;
// Declare string totalDeductionsForPayPeriodString;
//Declare double overTimePay;
// Declare double regularPay;
// Declare double grossPay;
// Declare double taxes;
// Declare double netPay;
// Console.Write("Enter the Employee Id: ");
//EmployeeIdString = console.ReadLine();
// EmployeeId= int.parse(EmployeeIdString);
//// Console.Write("Enter the hourly Rate: ");
//hourlyRateString = console.ReadLine();
//hourlyRate= double.Parse(hourlyRateString);
//// Console.Write("Enter the number of Regular Hours Worked: ");
//regularHoursString = console.ReadLine();
// regularHours= double.parse(regularHoursString);
//Console.Write("Enter the number of Overtime Hours Worked(may be 0): ");
//overtimeHoursString = console.ReadLine();
//overtimeHours= double.Parse(overtimeHoursString);
//Console.Write("Enter the  total Deductions for the the Paying Period: ");
// totalDeductionsForPayPeriodString= console.ReadLine();
//  totalDeductionsForPayPeriod= double.Parse(totalDeductionsForPayPeriodString);
//regularPay = regularHours * hourlyRate;
//overTimePay = overTimeHours * hourlyRate * CHANGEOFOVERTIMEHOURSOVERREGULARHOURSRATE;
//grossPay = regularPay + overTimePay;
//taxes = grossPay * TAXRATE;
//Console.WriteLine($"Deductions: {deductions}");
//Console.WriteLine($"Net Pay Monetary Amounts: {netPay}");
//Steps below are step 4 Of  problem Solving Code your planning in a programming language 

const double TAXRATE= 0.3;
 const double CHANGEOFOVERTIMEHOURSOVERREGULARHOURSRATE= 1.5;

 int employeeId;
 double hourlyRate;
 double regularHours;
 double overTimeHours;
double totalDeductionsForPayPeriod;
string employeeIdString;
 string hourlyRateString;
string regularHoursString;
string overTimeHoursString;
string totalDeductionsForPayPeriodString;
double overTimePay;
double regularPay;
 double grossPay;
 double taxes;
 double netPay;

Console.Write("Enter the Employee Id: ");
employeeIdString = Console.ReadLine();
employeeId= int.Parse(employeeIdString);
Console.Write("Enter the hourly Rate: ");
hourlyRateString = Console.ReadLine();
hourlyRate= double.Parse(hourlyRateString);
Console.Write("Enter the number of Regular Hours Worked: ");
regularHoursString = Console.ReadLine();
regularHours= double.Parse(regularHoursString);
Console.Write("Enter the number of Overtime Hours Worked(may be 0): ");
overTimeHoursString = Console.ReadLine();
overTimeHours= double.Parse(overTimeHoursString);
Console.Write("Enter the  total Deductions for the the Paying Period: ");
totalDeductionsForPayPeriodString= Console.ReadLine();
totalDeductionsForPayPeriod= double.Parse(totalDeductionsForPayPeriodString);
regularPay = regularHours * hourlyRate;
overTimePay= overTimeHours * hourlyRate * CHANGEOFOVERTIMEHOURSOVERREGULARHOURSRATE;
grossPay = regularPay + overTimePay;
taxes= grossPay * TAXRATE;
netPay = grossPay - totalDeductionsForPayPeriod - taxes;
//Lines of Code below are my solution checking my answer
Console.WriteLine($"Pay Information for Employee: {employeeId}");
Console.WriteLine($"Monthly Gross Pay:  ${grossPay:F2}");
Console.WriteLine($"Taxes: ${taxes:F2}");
Console.WriteLine($"Deductions: ${totalDeductionsForPayPeriod:F2}");
Console.WriteLine($"Net Pay Monetary Amounts: ${netPay:F2}");

