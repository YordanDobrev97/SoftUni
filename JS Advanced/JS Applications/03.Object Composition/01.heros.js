function solve() {
    return {
        mage: function(name){
            this.healt = 100;
            this.mana = 100;

           return {
            cast: (spells) =>{
                this.mana--;
            }
           }
        },
        fighter: function(name) {
            
        }
    }
}

let create = solve();
const scorcher = create.mage("Scorcher");
scorcher.cast('fireball');

