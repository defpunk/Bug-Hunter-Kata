class Invoice {
    customer: string;
    performances: ProductionPerformance[];

    constructor(customer: string, performances: ProductionPerformance[]) {
        this.customer = customer;
        this.performances = performances;
    }
}


class ProductionPerformance {
    audience: number;

    constructor(audience: number) {
        this.audience = audience;
    }
}

class TheatreCreditReceipt {
    print(invoice: Invoice): string {
        let totalCredits = 0;
        let result = `Statement for ${invoice.customer}\n`;

        for (const performance of invoice.performances) {
            // Bug: It should give extra credits for every ten attendees
            let credits = Math.max(performance.audience - 30, 0);
            credits += Math.floor(performance.audience / 5);

            totalCredits += credits;
        }

        result += `You earned ${totalCredits} credits\n`;
        return result;
    }
}

export {Invoice, ProductionPerformance, TheatreCreditReceipt}