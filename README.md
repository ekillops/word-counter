# _Repeat Counter_

#### _C# Word Counter, 12/2/2016_

#### By _**Erik Killops**_

## Description

_Enter a phrase and a word or sequence of characters to count within the phrase and press 'Count'. You will be taken to another page with your results showing the word, the phrase, and the number of occurrences._

#### Specs

CountRepeats() Tests

| BEHAVIOR                                                           | INPUT                                                                             | OUTPUT |
|--------------------------------------------------------------------|-----------------------------------------------------------------------------------|--------|
| Count instances of a single character in a single character phrase | Word: "a", Phrase: "a"                                                            | 1      |
| Count instances of a multi-character word in a phrase              | Word: "cat", Phrase: "the fat cat"                                                | 1      |
| Ignore case in phrase when counting                                | Word: "cat", Phrase: "the Fat CaT"                                                | 1      |
| Do not ignore case in phrase if user chooses                       | Word: "South", Phrase: "south of South America", Match Case: Yes                  | 1      |
| Ignore apostrophes in phrase when counting if user chooses         | Word: "its", Phrase: "it's not its", Match Case: No, Ignore Apostrophes: Yes      | 2      |


## Setup/Installation Requirements

_Requires Windows and .Net_

Clone repository, run ">dnx kestrel" in Powershell and visit "localhost:5004".

## Known Bugs

None.


## Technologies Used

HTML, C#, Nancy, Razor, Xunit.

### License

*GPL*

Copyright (c) 2016 **_Erik Killops, Epicodus_**
