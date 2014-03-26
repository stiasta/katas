var fizzbuzz;
module("Dummy tests",
{
    setup: function ()
    {
        fizzbuzz = new Fizzbuzz();
    },
    teardown: function ()
    {
        fizzbuzz = undefined;
    }
});

test("check if it is false", function ()
{
    ok(fizzbuzz.dummyReturningFalse() == false, "the dummy function is not false!");
});

test("failing test! Comment out when you feel that is has lost its demo value ^^", function ()
{
    ok(fizzbuzz.dummyReturningFalse() == true, "the test failed because the dummy function is returning false and NOT true");
});