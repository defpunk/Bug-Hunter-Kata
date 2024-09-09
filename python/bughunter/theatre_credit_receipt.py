import math


class TheatreCreditReceipt:
    def print_statement(self, invoice):
        total_credits = 0
        result = f"Statement for {invoice.customer}\n"
        for performance in invoice.performances:
            # Bug: It should give extra credits for every ten attendees
            credits = max(performance.audience - 30, 0)
            credits += math.floor(performance.audience / 5)
            total_credits += credits

        result += f"You earned {total_credits} credits\n"
        return result
