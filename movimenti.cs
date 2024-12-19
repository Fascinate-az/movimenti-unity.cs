    void Update()
    {
        // Se premi la barra spaziatrice, fai saltare il corpo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, 10); // Imposta la velocità verticale per il salto
        }

        // Movimento verso destra (tasto freccia destra)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(1, rb.velocity.y); // Movimento verso destra
        }


        // Movimento verso sinistra (tasto freccia sinistra)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y); // Movimento verso sinistra
        }

        
        if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y); // Ferma completamente il movimento orizzontale
        }
    }
}

