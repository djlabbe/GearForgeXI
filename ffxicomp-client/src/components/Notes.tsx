import Card from "./Card";

const Notes = () => {
    return (
        <Card>
            <h2 className="font-semibold text-lg mb-2">Notes & Disclaimers</h2>
            <ul className="list-disc list-inside space-y-2">
                <li>Stats on items may be missing or incorrect.</li>
                <li>Many items are missing. This is very much a work in progress. New items will continue to be added. (Hopefully in bulk).</li>
                <li>Items are missing certain stats such as defense, HP, and MP. I hope to eventually fill in these gaps.</li>
                <li>
                    The copy set button does not yet generate any augments/enchants. You will likely need to populate your cape augments manually (or export from game).
                    <ul className="list-disc list-inside ml-6 mt-1">
                        <li>Similarly, if you have multiple Rostams or similar items, you will need to add augments and/or bag information manually.</li>
                    </ul>
                </li>
            </ul>
        </Card>
    )
};

export default Notes;