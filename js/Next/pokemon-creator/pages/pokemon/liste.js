import Image from 'next/image';
import Link from 'next/link';
import React from 'react';

const pokemon = require('pokemon');
let id  = 0;
class PokemonListe extends React.Component
{
    constructor(props){
        super(props);
        console.log("test");
    }
    render(){
        return (
            <div>
            
            <Link href="../" replace><h1>Liste des pokemon</h1></Link>
            {
                
                pokemon.all('fr').map(d => 
                    
                <Link href={{pathname: 'https://www.pokepedia.fr/' + d}}> <p key={++id}>{d}</p></Link>
                )
                
            }
            <Image src='/images/pikachu.png' alt='photopika' width={500} height={100}></Image>
            </div>
        );
    }
}

export default PokemonListe;