export default class Fizzer {
    fizz(number: number): string {
        // Bug: It should return "Fizz" if the number is divisible by 3.
        // Otherwise, it should return the number as a string.
        if (number / 3 == 0) {
            return "Fizz";
        } else {
            return number.toString();
        }
    }
}
