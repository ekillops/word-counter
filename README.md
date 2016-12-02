# Repeat Counter

#### By **Erik Killops**

## Description

Enter a phrase and a word or sequence of characters to count within the phrase and press 'Count'.

#### Specs

CountRepeats() Tests

| BEHAVIOR                                                           | INPUT                                                           | OUTPUT |
|--------------------------------------------------------------------|-----------------------------------------------------------------|--------|
| Count instances of a single character in a single character phrase | Word: "a" Phrase: "a"                                           | 1      |
| Count instances of a multi-character word in a phrase              | Word: "cat" Phrase: "the fat cat"                               | 1      |
| Ignore case in phrase when counting                                | Word: "cat" Phrase: "the Fat CaT"                               | 1      |
| Do not ignore case in phrase if user chooses                       | Word: "South" Phrase: "south of South America" Match Case: Yes  | 1      |
| Ignore apostrophes in phrase when counting if user chooses         | Word: "it's" Phrase: "it's not its" Apostrophes: Ignore         | 1      |


## Setup/Installation Requirements

Requires Windows and .Net

Clone repository, run ">dnx kestrel" in Powershell and visit "localhost:5004".

## Known Bugs

None.


## Technologies Used

HTML, C#, Nancy, Razor, Xunit.
