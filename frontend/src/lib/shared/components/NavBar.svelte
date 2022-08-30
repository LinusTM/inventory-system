<script type="ts">
	const navItems = [
		{ label: 'ADMIN', href: '/admin' },
		{ label: 'SØG', href: '/' }
	];
</script>

<div id="toolbar">
	<a id="img" href="/"><img src="./images/logo.png" alt="ZBC logo" /></a>
	<span class="spacer" />
	<div id="links">
		{#each navItems as navItem}
			<a href={navItem.href}>{navItem.label}</a>
		{/each}
	</div>
</div>

<style lang="scss">

	#toolbar {
		display: flex;
		flex-direction: row;
		position: sticky;
		width: 100%;
		height: 4rem;
		color: var(--text-light);
		background-color: var(--background-dark);
		font-size: 16px;
		align-items: center;
		box-shadow: 0 1px 2px hsla(0, 0%, 0%, 0.05), 0 1px 4px hsla(0, 0%, 0%, 0.05),
			0 2px 8px hsla(0, 0%, 0%, 0.05);

		a {
			text-decoration: none;
			transition: all 0.2s ease;
			font-size: 1.3rem;
			font-weight: 600;
			font-style: italic;
		}

		a:hover {
			border-bottom-width: 3px;
		}

		* {
			margin-right: 1em;
			margin-left: 1em;
		}

		.spacer {
			flex: 1 1 auto;
		}

		img {
			max-height: 2.3em;
			margin-top: 4.5%;
			padding-right: 2px;
			border-right: 2.5px solid #FFF;
		}

		#img {
			border-bottom: none;
		}
	}
</style>
