
using System; 
 
class GFG 
{ 
      
// Returns true if str1 is smaller 
// than str2, else false. 
static bool isSmaller(string str1,  
                      string str2) 
{ 
    // Calculate lengths of both string 
    int n1 = str1.Length,  
        n2 = str2.Length; 
  
    if (n1 < n2) 
        return true; 
    if (n2 > n1) 
        return false; 
  
    for (int i = 0; i < n1; i++) 
    { 
        if (str1[i] < str2[i]) 
            return true; 
        else if (str1[i] > str2[i]) 
            return false; 
    } 
    return false; 
} 
  

static string findDiff(string str1,  
                       string str2) 
{ 
    // Before proceeding further, 
    // make sure str1 is not smaller 
    if (isSmaller(str1, str2)) 
    { 
        string t = str1;  
        str1 = str2; 
        str2 = t; 
    } 
  
    // Take an empty string for  
    // storing result 
    String str = ""; 
  
    // Calculate lengths of both string 
    int n1 = str1.Length, n2 = str2.Length; 
    int diff = n1 - n2; 
  
    // Initially take carry zero 
    int carry = 0; 
  
    // Traverse from end of both strings 
    for (int i = n2 - 1; i >= 0; i--) 
    { 
        // Do school mathematics, compute  
        // difference of current digits and carry 
        int sub = (((int)str1[i + diff] - (int)'0') - 
                   ((int)str2[i] - (int)'0') - carry); 
        if (sub < 0) 
        { 
            sub = sub + 10; 
            carry = 1; 
        } 
        else
            carry = 0; 
  
        str += sub.ToString(); 
    } 
  
    // subtract remaining digits of str1[] 
    for (int i = n1 - n2 - 1; i >= 0; i--) 
    { 
        if (str1[i] == '0' && carry > 0) 
        { 
            str += "9"; 
            continue; 
        } 
        int sub = (((int)str1[i] - (int)'0') - carry); 
        if (i > 0 || sub > 0) // remove preceding 0's 
            str += sub.ToString(); 
        carry = 0; 
  
    } 
  
    // reverse resultant string 
    char[] aa = str.ToCharArray(); 
    Array.Reverse(aa); 
    return new string(aa); 
} 
  

public static void Main ()  
{ 
    String str1 = "88"; 
    String str2 = "1079"; 
    Console.WriteLine(findDiff(str1, str2)); 
} 

