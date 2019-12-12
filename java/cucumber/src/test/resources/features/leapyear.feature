@foo
Feature: Leap Year Calculator

  Scenario Outline: Not a leap year
    Given the year <year>
    When I check for leap year
    Then the check result is <isLeap>

    Examples: year not div by 4
      | year | isLeap |
      | 1999 | no     |
      | 2001 | no     |
      | 2002 | no     |
      | 2013 | no     |
      | 2017 | no     |
      | 2015 | no     |

    Examples: year div by 100
      | year | isLeap |
      | 1900 | no     |
      | 2100 | no     |
      | 1700 | no     |

  Scenario Outline: Is a leap year
    Given the year <year>
    When I check for leap year
    Then the check result is <isLeap>

    Examples: year div by 4
      | year | isLeap |
      | 2004 | yes    |
      | 2008 | yes    |
      | 1112 | yes    |
      | 2424 | yes    |
      | 2048 | yes    |
      | 4    | yes    |


    Examples: year div by 400
      | year | isLeap |
      | 2000 | yes    |
      | 1600 | yes    |
      | 2400 | yes    |
