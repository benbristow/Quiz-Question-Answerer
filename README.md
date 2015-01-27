# Quiz Question Answerer

![Screenshot](http://a.pomf.se/uvthmh.PNG)

Attempts to answer quiz questions using the Bing Search API and some simple trickery.

## How to use

* Grab a free API key from https://datamarket.azure.com/dataset/bing/search (Requires a Microsoft Account, free) - Each API key is limited to 5,000 searches per month (aka 5,000 questions per month) unless you pay. Not bad for free, 'eh?

* Import into Visual Studio 2013

* Open up Question.cs and replace `change_me` with your api key.

* Compile and run!

## How it works

* Take a question and use it as the search query. 

* Get JSON response from Bing and deserialize with Newtonsoft JSON .NET

* Loop through each description from results. Strip out words that are included in an answer. For example if we had, 'Who is John Wick?' and one answer is 'John Travolta', we'd remove the word 'John'.

* Loop through each word in the description, and loop through each word in an answer. If an answer contains a word that is contained in a description, increment it's value (each answer is a class) by 1.

* Return the result that has the highest count.

## Acknowledgements

* Bing Azure Search API - https://datamarket.azure.com/dataset/bing/search

* NewtonSoft JSON .NET - https://www.newtonsoft.com/json

* MoreLinQ - https://www.nuget.org/packages/morelinq/
