import { CurrentArray } from "./current-array";
import { CurrentPlayer } from "./current-player";
import { PlayerNames } from "./player-names";

export class Purses extends CurrentArray<number> {

    names: PlayerNames;

    public constructor(currentPlayer: CurrentPlayer, names: PlayerNames) {
        super(currentPlayer, 0);
        this.names = names;
    }

    public inc(): void {
        this.add();
        this.println();
    }

    private add(): void {
        this.set(this.currentPlayer.get(), this.current() + 1);
    }

    private println(): void {
        console.log(this.names.get()
            + " now has "
            + this.current()
            + " Gold Coins.");
    }

}
